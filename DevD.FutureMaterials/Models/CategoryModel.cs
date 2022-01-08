using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevD.FutureMaterials.Models
{
    [Table("CATEGORY")]
    public class CategoryModel
    {
        [Key,
         Column("")]
        public int Id { get; set; }

        [Column(""),
         Display(Name = "Description:"),
         Required(ErrorMessage = "Required!")]
        public string? Description { get; set; }

        [Column(""),
         Display(Name = "Marketed:"),
         Required(ErrorMessage = "Required!")]
        public bool Marketed { get; set; }

        public int DisplayOrder { get; set; }

        public IList<ProductModel>? Products { get; set; }
    }
}
