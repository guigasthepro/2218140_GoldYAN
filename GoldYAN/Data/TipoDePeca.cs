using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("tiposdepeca")]
    public class TipoDePeca
    {
        [ExplicitKey]
        public int? idpeca { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
    }
}
