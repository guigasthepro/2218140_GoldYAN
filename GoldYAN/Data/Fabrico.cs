using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("fabrico")]
    public class Fabrico
    {
        [ExplicitKey]
        public int idfabrico { get; set; }
        public int linha { get; set; }
        public int? idservico { get; set; }
        public int? idprodutos { get; set; }
        [Computed] public string descricao { get; set; }
        public double quantidade { get; set; }
        public double custo { get; set; }
        public double peso { get; set; }
        public double custototal { get; set; }
        public double customedio { get; set; }
        [Computed] public string formadepesquisa { get; set; }
        public string datacriacao { get; set; }

    }
}
