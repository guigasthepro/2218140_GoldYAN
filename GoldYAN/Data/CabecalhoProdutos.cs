using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("cabecalhoproduto")]
    public class CabecalhoProdutos
    {
        [ExplicitKey]
        public int idproduto { get; set; }
        public string? idmodelo { get; set; }
        public int idclassificação { get; set; }
        public int idunidade { get; set; }
        public int idcompra { get; set; }
        public string descricao { get; set; }
        public string apontamentos { get; set; }
        public int idtipodeproduto { get; set; }
        public int idtipodepeca { get; set; }
        public int? idfornecedor { get; set; }
        public double? preco { get; set; }
        public double? stock { get; set; }
        [Computed] public double? updatestock{ get; set; }
        [Computed] public double? stocktotal { get; set; }
        [Computed] public bool produtonovo { get; set; }

    }
}
