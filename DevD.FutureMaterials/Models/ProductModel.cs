using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevD.FutureMaterials.Models
{
    [Table("PRODUCT")]
    public class ProductModel
    {
        [Key,
         Column("PRODUCTID")]
        public int Id { get; set; }

        [Column("NAME"),
         Required(ErrorMessage = "The name field is required.")]
        public string? Name { get; set; }

        [Column("CHARACTERISTICS"),
         Display(Name = "Characteristics"),
         Required(ErrorMessage = "The characteristics field is required.")]
        public string? Characteristic { get; set; }

        [Column("MIDPRICE"),
         Display(Name = "Midium price"),
         Required(ErrorMessage = "The midium price field is required.")]
        public double MidPrice { get; set; }

        [Column("LOGO"),
         Required(ErrorMessage = "The logo field is required.")]
        public string? Logo { get; set; }

        [Column("ACTIVE")]
        public bool Active { get; set; }

        public CategoryModel? Category { get; set; }
    }
}
