using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    public class EncomendasComputed
    {
        [Computed]
        public string idwithlinha { get; set; }
        public int idencomenda { get; set; }
        public int linha { get; set; }
        public int idservico { get; set; }
        public int idcliente { get; set; }
        [Computed]
        public string nome { get; set; }
        [Computed]
        public int telefone { get; set; }
        public string criadopor { get; set; }
        public string apontamentos { get; set; }
        public string idestado { get; set; }
        public int quantidade { get; set; }
        public string peso { get; set; }
        public double precounitario { get; set; }
        public double precototal { get; set; }
        public DateTime datadeentrega { get; set; }
        public DateTime data { get; set; }

    }
}
