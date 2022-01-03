using System.ComponentModel.DataAnnotations;

namespace DevD.FutureMaterials.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public string? Caracteristica { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public double PrecoMedio { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public string? Logotipo { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public bool Ativo { get; set; }

        public CategoryModel? TipoProduto { get; set; }
    }
}
