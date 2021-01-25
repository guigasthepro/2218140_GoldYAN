using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table ("encomendas")]
    public class Encomendas
    {
        [ExplicitKey]
        public int idencomenda { get; set; }
        public int idfabrico { get; set; }
        [Required]
        public int IdCliente { get; set; }
        public int produtoid { get; set; }
        public int criadopor { get; set; }
        public int estado { get; set; }
        public string datacriada { get; set; }
        public string quantidade { get; set; }
        public string peso { get; set; }
        public string precounitario { get; set; }
        public string desconto { get; set; }
        public string precototal { get; set; }

    }
}
