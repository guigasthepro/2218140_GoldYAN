using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("compras")]
    public class Compras
    {
        [ExplicitKey]
        public int idfatura { get; set; }
        public int idfornecedor { get; set; }
        public int numero { get; set; }
        public string apontamentos { get; set; }
        public float preco { get; set; }
        public string datacriacao { get; set; }
    }
}
