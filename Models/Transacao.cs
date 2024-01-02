using System;

namespace ContasAPagar.Models
{

    public class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public long Valor { get; set; }
        public DateTime DataTransacao { get; set; }
        public TipoTransacao TipoTransacao { get; set; }
    }
}