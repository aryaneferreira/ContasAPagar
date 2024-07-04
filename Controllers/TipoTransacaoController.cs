using ContasAPagar.Dto;
using ContasAPagar.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoTransacaoController : ControllerBase
    {
        private ITipoTransacaoService _tipoTransacaoService;

        public TipoTransacaoController(ITipoTransacaoService tipoTransacaoService)
        {
            _tipoTransacaoService = tipoTransacaoService;
        }
        // posteriormente precisa estar com [Authorize]
        [AllowAnonymous]
        [HttpGet]
        [Route("listar")]
        public IEnumerable<TipoTransacaoOutputModel> ObtemTiposTransacao()
        {
            return _tipoTransacaoService.ObtemTiposTransacao();
        }
    }
}
