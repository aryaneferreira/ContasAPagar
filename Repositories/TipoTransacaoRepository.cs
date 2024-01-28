using ContasAPagar.Db;
using ContasAPagar.Model;
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
        public IEnumerable<TipoTransacao> ObtemTiposTransacao()
        {
            var resultado = new List<TipoTransacao>();
            resultado = _context.TiposTransacao.ToList();

            return resultado;
        }
    }
}
