using Microsoft.Extensions.Options;
using System.Text.Json;

namespace FCG_API_Jogos.Services
{
    public class PagamentoApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _subscriptionKey;

        public PagamentoApiService(HttpClient httpClient, IOptions<ApiSettings> apiSettings)
        {
            _httpClient = httpClient;
            var config = apiSettings.Value.Pagamentos;
            _subscriptionKey = config.SubscriptionKey;
            _httpClient.BaseAddress = new Uri(config.BaseUrl);
        }

        public async Task<HttpResponseMessage> CriarTransacaoAsync(object payload)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "Pagamentos/ProcessarPagamento")
            {
                Content = JsonContent.Create(payload)
            };

            request.Headers.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);

            return await _httpClient.SendAsync(request);
        }

        public async Task<string> ObterStatusTransacaoAsync(Guid id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"Pagamentos/ConsultarStatusPagamento/{id}");
            request.Headers.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);

            return doc.RootElement.GetProperty("result").GetProperty("status").GetString();
        }
    }

    public class ApiSettings
    {
        public PagamentosConfig Pagamentos { get; set; } = new();
    }

    public class PagamentosConfig
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string SubscriptionKey { get; set; } = string.Empty;
    }
}
