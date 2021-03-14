using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table ("modelos")]
    public class Modelos
    {
        [ExplicitKey]
        public string idmodelo { get; set; }
        public int linha { get; set; }
        public int idcolaborador { get; set; }
        public int idmolde { get; set; }
        public int idservico { get; set; }
        [Computed]
        public string codigo { get; set; }
        [Computed]
        public string descricao { get; set; }
        public int idproduto { get; set; }
        public double? quantidade { get; set; }
        public double? peso { get; set; }
        public double? preco { get; set; }
        public double? valortotal { get; set; }
        [Computed] public string formadepesquisa { get; set; }


    }
}
