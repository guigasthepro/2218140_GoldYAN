using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN.Data
{
    [Table("localizações")]
    public class Localizacoes
    {
        [ExplicitKey]
        public int idlocalizacao { get; set; }
        public string descricao { get; set; }
    }
}
