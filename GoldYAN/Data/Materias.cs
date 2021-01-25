using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("materias")]
    public class Materias
    {
        [ExplicitKey]
        public int idmateria { get; set; }
        public string alcunha { get; set; }
        public string nome { get; set; }
    }
}
