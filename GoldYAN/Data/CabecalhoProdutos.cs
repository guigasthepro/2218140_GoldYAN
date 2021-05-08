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
        public string  referenciafornecedor { get; set; }
        public string descricao { get; set; }
        public string apontamentos { get; set; }
        public int idtipodeproduto { get; set; }
        public int idtipodepeca { get; set; }
        public int? idfornecedor { get; set; }
        public double? feitiogr  { get; set; }
        public double? feitiopeca { get; set; }
        public double? cotacao { get; set; }
        public double? margem { get; set; }
        public double? preco { get; set; }
        public double? pvp { get; set; }
        public double? stock { get; set; }
        public double? peso { get; set; }
        public string datacriacao { get; set; }

        [Computed] public double? updatestock{ get; set; }
        [Computed] public double? stockantigo { get; set; }
        [Computed] public double? custototal { get; set; }
        [Computed] public double? stocktotal { get; set; }
        [Computed] public bool produtonovo { get; set; }
        [Computed] public int idcompra { get; set; }
        [Computed] public int linha { get; set; }


    }
}
