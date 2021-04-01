using Dapper.Contrib.Extensions;
using Microsoft.CodeAnalysis.Operations;

namespace GoldYAN.Data
{
    [Table("produtos")]
    public class Produtos
    {
        public int idproduto { get; set; }
        public int idlinha { get; set; }
        public int ?idservico { get; set; }
        public int ?idprodutos { get; set; }
        [Computed] public string descricao { get; set; }
        public int idcolaborador { get; set; }
        public double quantidade { get; set; }
        public double custo { get; set; }
        public double peso { get; set; }
        public double custototal { get; set; }
        public double customedio { get; set; }
        public string datacriacao { get; set; }

    }
}
