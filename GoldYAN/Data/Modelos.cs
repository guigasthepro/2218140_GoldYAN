using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Http;

namespace GoldYAN.Data
{
    [Table ("modelos")]
    public class Modelos
    {
        [ExplicitKey]
        public string idmodelo { get; set; }
        public int linha { get; set; }
        [Required(ErrorMessage = "A quantidade não pode ser nula")]
        public int idcolaborador { get; set; }
        public int? idmolde { get; set; }
        public int? idservico { get; set; }
        [Computed]
        public string codigo { get; set; }
        [Computed]
        public string descricao { get; set; }
        public int? idproduto { get; set; }
        [Required(ErrorMessage ="A quantidade não pode ser nula")]
        public double? quantidade { get; set; }
        [Required(ErrorMessage = "A quantidade não pode ser nula")]
        public double? peso { get; set; }
        [Required(ErrorMessage = "A quantidade não pode ser nula")]
        public double? preco { get; set; }
        [Required(ErrorMessage = "A quantidade não pode ser nula")]
        public double? valortotal { get; set; }
        [Computed] public string formadepesquisa { get; set; }
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".bmp" })]
        public IFormFile Image { get; set; }


    }
}
