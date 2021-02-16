using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Dapper.Contrib.Extensions.Table("codigopostal")]
    public class Codigopostal
    {
        [ExplicitKey]
        public int idcodigopostal { get; set; }
        public string descricao { get; set; }
    }
}
