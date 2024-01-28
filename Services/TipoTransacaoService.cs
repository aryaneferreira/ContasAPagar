using ContasAPagar.Models;
using ContasAPagar.Repositories;

namespace ContasAPagar.Services
{
    public class TipoTransacaoService : ITipoTransacaoService
    {
        private ITipoTransacaoRepository _tipoTransacaoRepository;

        public TipoTransacaoService(ITipoTransacaoRepository repository)
        {
            _tipoTransacaoRepository = repository;
        }
        public IEnumerable<TipoTransacao> ObtemTiposTransacao()
        {
            return this._tipoTransacaoRepository.ObtemTiposTransacao();
        }
    }
}
