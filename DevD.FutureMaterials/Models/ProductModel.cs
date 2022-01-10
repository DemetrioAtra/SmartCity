using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevD.FutureMaterials.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "The name field is required.")]
        public string Name { get; set; }

        [Display(Name = "Characteristics"),
         Required(ErrorMessage = "The characteristics field is required.")]
        public string Characteristic { get; set; }

        [Display(Name = "Midium price"),
         Required(ErrorMessage = "The midium price field is required.")]
        public double MidPrice { get; set; }

        [Required(ErrorMessage = "The logo field is required.")]
        public string Logo { get; set; }

        public bool Active { get; set; }
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
    }
}
