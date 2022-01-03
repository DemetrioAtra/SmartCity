using System.ComponentModel.DataAnnotations;

namespace DevD.FutureMaterials.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public bool Comercializado { get; set; }

        [Required(ErrorMessage = "Required!"),
         Display(Name = "")]
        public int Ordens { get; set; }

        public IList<ProductModel>? Products { get; set; }
    }
}
