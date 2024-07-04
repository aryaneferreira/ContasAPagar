using System;

namespace ContasAPagar.Models
{

    public class Transacao
    {
        public int TransacaoId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public int TipoTransacaoId { get; set; }
        public int CartaoId { get; set; }
    }
}