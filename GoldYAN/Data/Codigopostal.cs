using System.ComponentModel.DataAnnotations.Schema;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Dapper.Contrib.Extensions.Table("codigopostal")]
    public class Codigopostal
    {
        [ExplicitKey]
        public int idcodigopostal { get; set; }
        public string nome_localidade { get; set; }
        public int num_cod_postal { get; set; }
        public int ext_cod_postal { get; set; }
        public string desig_postal { get; set; }
        
    }
}
