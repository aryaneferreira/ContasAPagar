using ContasAPagar.Model;
using ContasAPagar.Models;

namespace ContasAPagar.Repositories
{
    public interface ITipoTransacaoRepository
    {
        IEnumerable<TipoTransacao> ObtemTiposTransacao();
    }
}
