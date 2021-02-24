using System;
using Dapper.Contrib.Extensions;
using Microsoft.EntityFrameworkCore.Storage;

namespace GoldYAN.Data
{
    [Table ("produtos")]
    public class Moldes
    {
        [ExplicitKey]
        public int idproduto { get; set; }
        public int tipoproduto { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public int gaveta { get; set; }
        public string tempo { get; set; }
        public int peso { get; set; }
    }
}
