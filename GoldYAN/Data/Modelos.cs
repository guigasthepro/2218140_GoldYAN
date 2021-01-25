using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table ("modelos")]
    public class Modelos
    {
        [ExplicitKey]
        [Required]
        public int idmodelo { get; set; }
        public int idmolde { get; set; }
        public string alcunha { get; set; }
        public string nome { get; set; }
        public int idmateria { get; set; }
        public int idservicos { get; set; }
        public int idfproduto { get; set; }

    }
}
