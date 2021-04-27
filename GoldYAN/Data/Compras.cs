using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN.Data
{
    [Table("compras")]
    public class Compras
    {
        [ExplicitKey]
        public int idcompra { get; set; }
        public int linha { get; set; }
        public int idproduto { get; set; }
        public double quantidade { get; set; }
        public double preco { get; set; }
        [Computed] public bool produtonovo { get; set; }

    }
}
