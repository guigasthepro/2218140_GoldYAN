using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace GoldYAN.Data
{
    [Table ("fornecedores")]
    public class Fornecedores
    {
        //Cabeçalho Encomenda//
        [ExplicitKey]
        public int idfornecedor { get; set; }
        [Required]
        public string codigo { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public string contacto { get; set; }
        [Required]
        public string nif { get; set; }
        public string morada { get; set; }
        public string localizaçao { get; set; }
        public string codigopostal { get; set; }
        public string telefone { get; set; }
        public string telemovel { get; set; }
        public string nomevendedor { get; set; }
        public string telemovelvendedor { get; set; }
    }
}
