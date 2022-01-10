using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevD.FutureMaterials.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The description field is required.")]
        public string Description { get; set; }

        public bool Marketed { get; set; }

        public int DisplayOrder { get; set; }

        public IList<ProductModel>? Products { get; set; }
    }
}
