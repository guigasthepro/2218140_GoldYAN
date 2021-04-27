using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN.Data
{
    [Table("tipodecompra")]
    public class TipodeCompra
    {
        [ExplicitKey]
        public int idtipocompra { get; set; }
        public string descricao  { get; set; }
    }
}
