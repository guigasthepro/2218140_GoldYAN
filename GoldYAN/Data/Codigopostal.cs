using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("codigopostal")]
    public class Codigopostal
    {
        [ExplicitKey]
        public int idcodigopostal { get; set; }
        public string codigopostal { get; set; }
        public string descricao { get; set; }
    }
}
