using AutenticacaoEAutorizacaoCorreto.Services;
using AutenticacaoEAutorizacaoCorreto.Services.IService;
using Azure.Monitor.OpenTelemetry.Exporter;
using FCG_API_Jogos.Context;
using FCG_API_Jogos.Entidades.Dtos;
using FCG_API_Jogos.Infra;
using FCG_API_Jogos.Infra.Middleware;
using FCG_API_Jogos.Models;
using FCG_API_Jogos.Models.Configuration;
using FCG_API_Jogos.Services;
using FCG_API_Jogos.Services.IService;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Nest;
using OpenTelemetry.Trace;
using Prometheus;
using Serilog;
using System.Text;

#region Configuration
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(options => options.ListenAnyIP(80));
#endregion

#region Authentication & Authorization
builder.Services.AddCors();
builder.Services.AddControllers();

var key = Encoding.ASCII.GetBytes(builder.Configuration["ConfigSecret:Secret"]);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

builder.Services.AddAuthorization(options =>
{
    options.PoliticasCustomizadas();
});
#endregion

#region Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Por favor, insira 'Bearer' [espaço] e o token JWT",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new String[]{}
        }
    });

    c.EnableAnnotations();
});
#endregion

#region Services & Database

Serilog.Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.ApplicationInsights(
        builder.Configuration["ApplicationInsights:ConnectionString"],
        TelemetryConverter.Traces)
    .CreateLogger();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), sqlOptions => sqlOptions.EnableRetryOnFailure()));

builder.Services.Configure<ConfigSecret>(builder.Configuration.GetSection("ConfigSecret"));

builder.Services.AddSingleton<IElasticClient>(sp =>
{
    var config = builder.Configuration.GetSection("ElasticSearch");
    var settings = new ConnectionSettings(new Uri(config["Uri"]))
        .DefaultIndex(config["DefaultIndex"]);
    return new ElasticClient(settings);
});

builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddOpenTelemetry()
    .WithTracing(trace =>
    {
        trace
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddEntityFrameworkCoreInstrumentation()
            .AddAzureMonitorTraceExporter();
    });

builder.Host.UseSerilog();

builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<ICacheService, MemCacheService>();
builder.Services.AddScoped<IJogoElasticService, JogoElasticService>();
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));
builder.Services.AddHttpClient<PagamentoApiService>();
builder.Services.AddCorrelationIdGenerator();
builder.Services.AddTransient(typeof(BaseLogger<>));
builder.Services.AddHttpContextAccessor();
//builder.Services.AddScoped(IUsuarioService, UsuarioService);

builder.Services.AddMemoryCache();
#endregion

#region Application Pipeline
var app = builder.Build();
//app.MapGet("/", () => Results.Text("Bem-vindo a FiapCloudGames!!!", "text/plain"));
#endregion

#region Telemetry
app.Use(async (context, next) =>
{
    if (!context.Request.Headers.ContainsKey("traceparent"))
    {
        var activity = System.Diagnostics.Activity.Current;
        if (activity != null)
            context.Request.Headers["traceparent"] = activity.Id;
    }

    await next();
});
#endregion


#region ElasticSearch
using (var scope = app.Services.CreateScope())
{
    var client = scope.ServiceProvider.GetRequiredService<IElasticClient>();

    if (!client.Indices.Exists("games").Exists)
    {
        client.Indices.Create("games", c => c
            .Map<JogoElasticDto>(m => m
                .AutoMap()
                .Properties(p => p
                    .Number(n => n.Name(nn => nn.UsuariosId).Type(NumberType.Long))
                    .Text(t => t.Name(n => n.Nome).Analyzer("standard"))
                    .Text(t => t.Name(n => n.Descricao).Analyzer("standard"))
                    .Object<CategoriaElasticDto>(o => o
                        .Name(n => n.Categoria)
                        .Properties(pp => pp
                            .Text(t => t
                                .Name(nn => nn.Descricao)
                                .Fields(f => f
                                    .Keyword(k => k.Name("keyword"))
                                )
                            )
                        )
                    )
                    .Number(nu => nu.Name(n => n.NumeroVendas))
                )
            )
        );
    }
}


#endregion

#region Middleware
if (app.Environment.IsDevelopment() || app.Environment.IsStaging() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "FiapCloudGamesAPI v1");
    });
}

app.UseCorrelationMiddleware();
app.UseInfoUsuarioMiddleware();
app.UseTratamentoDeErrosMiddleware();
#endregion

#region Request Pipeline
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
#endregion

#region Endpoint Mapping & Execution
app.UseHttpMetrics();
app.MapMetrics();
app.MapControllers();
app.Run();
#endregion