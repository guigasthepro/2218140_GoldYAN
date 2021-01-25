using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("stock")]
    public class Stock
    {
        [ExplicitKey]
        public int idstock { get; set; }
        public int idproduto { get; set; }
        public int quantidade { get; set; }

    }
}
