using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("tipoproduto")]
    public class TipoProduto
    {
        [ExplicitKey]
         public int? idtipoproduto { get; set; }
         public string codigo { get; set; }
         public string descricao { get; set; }
    }
}
