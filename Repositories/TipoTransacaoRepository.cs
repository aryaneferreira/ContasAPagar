using ContasAPagar.Db;
using ContasAPagar.Dto;
using ContasAPagar.Models;

namespace ContasAPagar.Repositories
{
    public class TipoTransacaoRepository : ITipoTransacaoRepository
    {
        private readonly ContasAPagarContext _context;

        public TipoTransacaoRepository(ContasAPagarContext context)
        {
            _context = context;
        }
        public IEnumerable<TipoTransacaoOutputModel> ObtemTiposTransacao()
        {
            var resultado = new List<TipoTransacaoOutputModel>();
            var tiposTransacao = _context.TiposTransacao.ToList();
            resultado = tiposTransacao.Select(a => new TipoTransacaoOutputModel { Nome = a.Nome, TipoTransacaoId = a.TipoTransacaoId}).ToList();

            return resultado;
        }
    }
}
