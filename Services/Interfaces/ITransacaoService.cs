using ContasAPagar.Dto;

namespace ContasAPagar.Services
{
    public interface ITransacaoService
    {
        IEnumerable<TransacaoOutputModel> ObtemTransacoes();
    }
}
