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
        protected readonly string _usuarioName;
        protected readonly Guid? _usuarioId;

        public BaseController(AppDbContext context, BaseLogger<T> logger, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _logger = logger;
            _usuarioName = httpContextAccessor?.HttpContext?.Items["UsuarioName"] as string;
            _usuarioId = httpContextAccessor?.HttpContext?.Items["UsuarioId"] as Guid? ;
        }

        protected string NomeUsuarioLogado => _usuarioName ?? string.Empty;

        protected Guid IdUsuarioLogado => _usuarioId ?? new Guid();
    }
}
