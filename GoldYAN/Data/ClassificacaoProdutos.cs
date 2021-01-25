using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    public class ClassificacaoProdutos
    {

        [ExplicitKey]
        public int classificacaoid { get; set; }
        public int codigo { get; set; }
        public string descricao { get; set; }
        public string codigoat { get; set; }
        public bool inventario { get; set; }
    }
}
