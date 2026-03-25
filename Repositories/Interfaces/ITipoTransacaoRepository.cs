using ContasAPagar.Dto;

namespace ContasAPagar.Repositories
{
    public interface ITipoTransacaoRepository
    {
        IEnumerable<TipoTransacaoOutputModel> ObtemTiposTransacao();
    }
}
