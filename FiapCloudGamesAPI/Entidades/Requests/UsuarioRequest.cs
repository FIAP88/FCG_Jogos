using FCG_API_Jogos.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace FCG_API_Jogos.Entidades.Requests
{
    public class UsuarioRequest : BaseRequest
    {
        public required string Nome { get; set; } 
        public required string Sobrenome { get; set; } 
        public required string Apelido { get; set; }
        public required string Email { get; set; } 
        public required string Senha { get; set; } 
        public required DateTime DataNascimento { get; set; } 
        public required long PerfilId { get; set; } 
    }
}
