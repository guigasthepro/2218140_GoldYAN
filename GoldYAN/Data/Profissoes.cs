using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("profissoes")]
    public class Profissoes
    {
        [ExplicitKey]
        public int idprofissao { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
    }
}
