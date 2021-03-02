using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("servicos")]
    public class Servicos
    {   
        [ExplicitKey]
        public int idservico { get; set; }
        public string codigo { get; set; }
        public string? idfornecedor { get; set; }
        public int? idunidade { get; set; }
        public string descricao { get; set; }
        public double custo  { get; set; }
    }
}
