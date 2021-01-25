using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("fabrico")]
    public class Fabrico
    {
        [ExplicitKey]
        public  int idfabrico { get; set; }
    }
}
