using ContasAPagar.Dto;

namespace ContasAPagar.Repositories
{
    public interface ITransacaoRepository
    {
        IEnumerable<TransacaoOutputModel> ObtemTransacoes();
    }
}
