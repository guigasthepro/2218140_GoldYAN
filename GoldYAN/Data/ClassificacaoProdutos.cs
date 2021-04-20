using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("classificacaoprodutos")]
    public class ClassificacaoProdutos
    {

        [ExplicitKey]
        public int IDClassificacao { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public string codigoat { get; set; }
        public int inventario { get; set; }
    }
}
