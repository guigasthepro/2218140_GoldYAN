using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("familiaprodutos")]
    public class FamiliaProdutos
    {
        [ExplicitKey]
        public int idfproduto { get; set; }
        public int idunidade { get; set; }
        public string tipo { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string descricaoeq { get; set; }
        public double toque { get; set; }


    }
}
