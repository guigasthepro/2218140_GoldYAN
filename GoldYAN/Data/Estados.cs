using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN.Data
{
    [Table("estados")]
    public class Estados
    {
        [ExplicitKey]
        public int idestados { get; set; }
        public string descricao { get; set; }
    }
}
