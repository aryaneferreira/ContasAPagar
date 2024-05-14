using ContasAPagar.Dto;
using ContasAPagar.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoTransacaoController : Controller
    {
        private ITipoTransacaoService _tipoTransacaoService;

        public TipoTransacaoController(ITipoTransacaoService tipoTransacaoService)
        {
            _tipoTransacaoService = tipoTransacaoService;
        }

        [HttpGet]
        [Route("listar")]
        public IEnumerable<TipoTransacaoOutputModel> ObtemTiposTransacao()
        {
            return _tipoTransacaoService.ObtemTiposTransacao();
        }
    }
}
