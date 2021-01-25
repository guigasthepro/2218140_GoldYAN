using System;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table ("molde")]
    public class Moldes
    {
        [ExplicitKey]
        public int idmolde { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public int idfproduto { get; set; }
        public int Gaveta { get; set; }
        public DateTime tempo { get; set; }
        public int peso { get; set; }
    }
}
