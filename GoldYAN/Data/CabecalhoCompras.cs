using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("cabecalhocompras")]
    public class CabecalhoCompras
    {
        [ExplicitKey]
        public int idcompra { get; set; }
        public int idfornecedor { get; set; }
        public int idtipodecompra { get; set; }
        public string numero { get; set; }
        public string apontamentos { get; set; }
        public string datacriacao { get; set; }
    }
}
