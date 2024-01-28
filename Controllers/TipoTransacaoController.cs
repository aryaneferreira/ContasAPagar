using ContasAPagar.Model;
using ContasAPagar.Models;
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
        [HttpGet(Name = "ObtemTipoTransacao")]
        public IEnumerable<TipoTransacao> ObtemTiposTransacao()
        {
            return _tipoTransacaoService.ObtemTiposTransacao();
        }
    }
}
