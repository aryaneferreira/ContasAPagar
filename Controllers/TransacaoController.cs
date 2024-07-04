using ContasAPagar.Dto;
using ContasAPagar.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransacaoController : ControllerBase
    {
        private ITransacaoService _transacaoService;

        public TransacaoController(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }
        // posteriormente precisa estar com [Authorize]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public IEnumerable<TransacaoOutputModel> ObtemTiposTransacao()
        {
            return _transacaoService.ObtemTransacoes();
        }
    }
}
