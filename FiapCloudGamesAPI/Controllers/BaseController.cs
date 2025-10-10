using FCG_API_Jogos.Context;
using FCG_API_Jogos.Infra;
using FCG_API_Jogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace FCG_API_Jogos.Controllers
{
    public class BaseController<T> : ControllerBase where T : class
    {
        protected readonly AppDbContext _context;
        protected readonly BaseLogger<T> _logger;
        protected readonly Usuario? _usuario;

        public BaseController(AppDbContext context, BaseLogger<T> logger, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _logger = logger;
            _usuario = httpContextAccessor?.HttpContext?.Items["Usuario"] as Usuario;
        }

        protected string NomeUsuarioLogado { get => _usuario?.Nome ?? string.Empty; }

        protected long IdUsuarioLogado => _usuario?.Id ?? 0;
    }
}
