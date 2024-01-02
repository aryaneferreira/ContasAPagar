using System;

namespace ContasAPagar.Models
{

    public class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public long Valor { get; set; }
        public DateTime MesVigente { get; set; }
        public TipoConta TipoConta { get; set; }
    }
}