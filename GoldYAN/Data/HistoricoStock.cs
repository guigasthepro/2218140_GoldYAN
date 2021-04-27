using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN.Data
{
    [Table("historicostock")]
    public class HistoricoStock
    {
        public int id { get; set; }
        public string tipocomponente { get; set; }
        public int idcomponente { get; set; }
        public string tipo { get; set; }
        public int idprodutoalterado { get; set; }
        public double stockinicial { get; set; }
        public double stockadicionado { get; set; }
        public double? stockfinal { get; set; }

        public string datacriacao { get; set; }

    }
}
