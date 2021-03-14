using System;
using Dapper.Contrib.Extensions;
using Microsoft.EntityFrameworkCore.Storage;

namespace GoldYAN.Data
{
    [Table ("molde")]
    public class Moldes
    {
        [ExplicitKey]
        public int idmolde { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string tipodepeça { get; set; }
        public int gaveta { get; set; }
        public string peso { get; set; }
        public string tipoproduto { get; set; }
    }
}
