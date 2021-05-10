using Dapper.Contrib.Extensions;
using Microsoft.CodeAnalysis.Operations;

namespace GoldYAN.Data
{
    [Table("produtos")]
    public class Produtos
    {
        [ExplicitKey]
        public int idproduto { get; set; }
        public int linha { get; set; }
        public int ?idservico { get; set; }
        public int ?idprodutos { get; set; }
        [Computed] public string descricao { get; set; }
        public int idcolaborador { get; set; }
        public double quantidade { get; set; }
        public double feitio { get; set; }
        public double cotacao { get; set; }
        public double custo { get; set; }
        public double peso { get; set; }
        public double custototal { get; set; }
        public double customedio { get; set; }
        [Computed] public string formadepesquisa { get; set; }
        public string datacriacao { get; set; }

    }
}
