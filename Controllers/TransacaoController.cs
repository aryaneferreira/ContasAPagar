using ContasAPagar.Dto;
using ContasAPagar.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransacaoController : Controller
    {
        private ITransacaoService _transacaoService;

        public TransacaoController(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }

        [HttpGet]
        [Route("listar")]
        public IEnumerable<TransacaoOutputModel> ObtemTiposTransacao()
        {
            return _transacaoService.ObtemTransacoes();
        }
    }
}
