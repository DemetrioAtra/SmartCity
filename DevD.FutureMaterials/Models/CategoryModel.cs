using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevD.FutureMaterials.Models
{
    [Table("CATEGORY")]
    public class CategoryModel
    {
        [Key,
         Column("CATEGORYID")]
        public int Id { get; set; }

        [Column("DESCRIPTION"),
         Required(ErrorMessage = "The description field is required.")]
        public string? Description { get; set; }

        [Column("MARKETED")]
        public bool Marketed { get; set; }

        public int DisplayOrder { get; set; }

        public IList<ProductModel>? Products { get; set; }
    }
}
