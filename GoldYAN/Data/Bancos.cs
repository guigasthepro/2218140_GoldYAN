using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("bancos")]
    public class Bancos
    {
        [ExplicitKey]
        public int idbanco { get; set; }
        public string codigobanco { get; set; }
        public string nome { get; set; }
    }
}
