using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("unidades")]
    public class Unidades
    {
        [ExplicitKey]
        public int idunidade { get; set; }
        public string indice { get; set; }
        public string descricao { get; set; }
    }
}
