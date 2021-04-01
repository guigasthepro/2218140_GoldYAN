using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    public class CabecalhoProdutos
    {
        [ExplicitKey]
        public int idproduto { get; set; }
        public int idmodelo { get; set; }
        public int idclassificação { get; set; }
        public int idunidade { get; set; }
        public string descricao { get; set; }
        public string apontamentos { get; set; }
        public int idtipodeproduto { get; set; }
        public int idtipodepeca { get; set; }
        public int idfornecedor { get; set; }

    }
}
