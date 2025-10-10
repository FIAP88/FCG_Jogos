using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FCG_API_Jogos.Context;
using FCG_API_Jogos.Models;
using FCG_API_Jogos.Infra;
using FCG_API_Jogos.Entidades.Dtos;
using FCG_API_Jogos.Entidades.Requests;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;

namespace FCG_API_Jogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Gerenciamento de Empresas Fornecedoras")]
    public class EmpresasFornecedoraController(AppDbContext context, BaseLogger<EmpresaFornecedora> logger, IHttpContextAccessor httpContext) :
        BaseControllerCrud<EmpresaFornecedora>(context, logger, httpContext)
    {

        [HttpGet]
        [Authorize(Policy = "BuscarEmpresasFornecedoras")]
        [SwaggerOperation("Buscar todas as empresas fornecedoras")]
        public async Task<ActionResult<IEnumerable<EmpresaFornecedoraDto>>> GetPermissoes() => await GetAll<EmpresaFornecedoraDto>();

        [HttpGet("{id}")]
        [Authorize(Policy = "BuscarEmpresasFornecedorasPorId")]
        [SwaggerOperation("Buscar empresa fornecedora por ID")]
        public async Task<ActionResult<EmpresaFornecedora>> GetEmpresaFornecedora(long id) => await GetById(id);

        [HttpPut("{id}")]
        [Authorize(Policy = "AtualizarEmpresasFornecedoras")]
        [SwaggerOperation("Atualizar empresa fornecedora por ID")]
        public async Task<IActionResult> PutEmpresaFornecedora(long id, EmpresaFornecedoraRequest empresaFornecedoraRequest) =>
            await Update(id, ConvertTypes(empresaFornecedoraRequest));

        [HttpPost]
        [Authorize(Policy = "CriarEmpresasFornecedoras")]
        [SwaggerOperation("Criar nova empresa fornecedora")]
        public async Task<ActionResult<EmpresaFornecedora>> PostEmpresaFornecedora(EmpresaFornecedoraRequest empresaFornecedoraRequest) =>
            await Create(ConvertTypes(empresaFornecedoraRequest));

        [HttpDelete("{id}")]
        [Authorize(Policy = "DeletarEmpresasFornecedoras")]
        [SwaggerOperation("Deletar empresa fornecedora por ID")]
        public async Task<IActionResult> DeleteEmpresaFornecedora(long id) => await Delete(id);

        protected override bool EntityExists(long id) => _context.EmpresasFornecedoras.Any(e => e.Id == id);
    }
}
