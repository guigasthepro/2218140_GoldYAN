using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldYAN.Data
{
    [Table("cabecalhofabrico")]
    public class CabecalhoFabrico
    {
        [ExplicitKey]
        public int idfabrico { get; set; }
        public string? idencomenda { get; set; }
        public string? descricao { get; set; }
        public int idproduto { get; set; }
        public string datacriacao { get; set; }

    }
}
