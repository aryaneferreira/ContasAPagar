using ContasAPagar.Models;

namespace ContasAPagar.Services
{
    public interface ITipoTransacaoService
    {
        IEnumerable<TipoTransacao> ObtemTiposTransacao();
    }
}
