using ContasAPagar.Dto;
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
        public IEnumerable<TipoTransacaoOutputModel> ObtemTiposTransacao()
        {
            return this._tipoTransacaoRepository.ObtemTiposTransacao();
        }
    }
}
