using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table ("Clientes")]
    public class Clientes
    {
        [ExplicitKey]
        public int idcliente { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Morada { get; set; }
        public string Moradaopcional { get; set; }
        [Required]
        public string Codigopostal { get; set; }
        [Required]
        public int Nif { get; set; }
        public string Profissao { get; set; }
    }
}