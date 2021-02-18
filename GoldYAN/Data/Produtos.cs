using Dapper.Contrib.Extensions;
using Microsoft.CodeAnalysis.Operations;

namespace GoldYAN.Data
{
    [Table("produtos")]
    public class Produtos
    {
        [ExplicitKey]
        public int idproduto { get; set; }
        public int familiaproduto { get; set; }
        public int tipoproduto { get; set; }
        public int idfornecedor{ get; set; }
        public int idfabrico { get; set; }
        public string codigo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int quantidade{ get; set; }
        public string contrastaria { get; set; }
        public int preco { get; set; }
        public int pvp { get; set; }
        public int customedio { get; set; }
        public int feitio { get; set; }
        public int feitiograma { get; set; }
        public int cotacao { get; set; }
        public int gaveta { get; set; }
        public string tempo { get; set; }
        public double peso { get; set; }
    }
}
