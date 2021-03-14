using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table("cabecalhomodelo")]
    public class CabecalhosModelos
    { 
        [Required]
        [ExplicitKey]
        public string idmodelo { get; set; }
        public int? idtipoproduto { get; set; }
        public int? idtipodepeca { get; set; }
        public string descricao { get; set; }
        public DateTime datacriacao { get; set; }
        public string criadopor { get; set; }
        //public FileStream? imagem { get; set; }

    }
}
