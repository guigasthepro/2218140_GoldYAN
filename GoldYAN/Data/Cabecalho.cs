using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using DapperExtensions.Sql;
using DapperExtensions.Mapper;


namespace GoldYAN.Data
{
    [Table("cabecalhoencomenda")]
    public class Cabecalho
    {
        [ExplicitKey]
        public int idencomenda { get; set; }
        public int idcliente { get; set; }
        public string localizacao { get; set; }
        public string estado { get; set; }
        public string criadopor { get; set; }
        public string data { get; set; }



    }
}
