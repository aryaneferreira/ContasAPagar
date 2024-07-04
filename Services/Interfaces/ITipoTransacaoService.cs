using ContasAPagar.Dto;

namespace ContasAPagar.Services
{
    public interface ITipoTransacaoService
    {
        IEnumerable<TipoTransacaoOutputModel> ObtemTiposTransacao();
    }
}
