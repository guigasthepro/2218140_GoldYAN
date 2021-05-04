using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Dapper.Contrib.Extensions;
using DapperExtensions.Sql;
using DapperExtensions.Mapper;
using Microsoft.VisualBasic;

namespace GoldYAN.Data
{
    [Table ("encomendas")]
    public class Encomendas
    {
        [ExplicitKey]
        public int idencomenda { get; set; }
        public int linha { get; set; }
        public int idservico { get; set; }
        [Computed]
        public string codigo { get; set; }
        [Computed]
        public string descricao { get; set; }
        public string apontamentos { get; set; }
        public string idlocalizacao { get; set; }
        public string idestado { get; set; }
        public string colaboradoratribuido { get; set; }
        public int quantidade { get; set; }
        public string peso { get; set; }
        public double precounitario { get; set; }
        public double precototal { get; set; }
        public DateTime datadeentrega  { get; set; }
        
    }
}
