using ContasAPagar.Db;
using ContasAPagar.Dto;

namespace ContasAPagar.Repositories
{
    public class TransacaoRepository: ITransacaoRepository
    {
        private readonly ContasAPagarContext _context;
        public TransacaoRepository(ContasAPagarContext context) {
            _context = context;
        }

        public IEnumerable<TransacaoOutputModel> ObtemTransacoes()
        {
            var resultado = new List<TransacaoOutputModel>();
            var tiposTransacao = _context.Transacoes.ToList();
            resultado = tiposTransacao.Select(a => new TransacaoOutputModel { TransacaoId = a.TransacaoId, Descricao = a.Descricao, 
                                                                              DataTransacao = a.DataTransacao, TipoTransacaoId = a.TipoTransacaoId,
                                                                              Valor = a.Valor }).ToList();
            return resultado;
        }
    }
}
