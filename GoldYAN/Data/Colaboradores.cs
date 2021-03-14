using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("colaboradores")]
    public class Colaboradores
    {
        [ExplicitKey]
        public int idcolaborador { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public double valor  { get; set; }
        public string servicoassociado { get; set; }
    }
}
