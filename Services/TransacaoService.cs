using ContasAPagar.Dto;
using ContasAPagar.Repositories;

namespace ContasAPagar.Services
{
    public class TransacaoService : ITransacaoService
    {
        private ITransacaoRepository _transacaoRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        public IEnumerable<TransacaoOutputModel> ObtemTransacoes()
        {
            return this._transacaoRepository.ObtemTransacoes();
        }
    }
}
