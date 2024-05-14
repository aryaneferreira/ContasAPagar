using ContasAPagar.Models;

namespace ContasAPagar.Dto
{
    public class TransacaoOutputModel
    {
        public int TransacaoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public int TipoTransacaoId { get; set; }
    }
}
