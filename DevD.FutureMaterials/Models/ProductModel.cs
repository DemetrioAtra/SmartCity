using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevD.FutureMaterials.Models
{
    [Table("PRODUCT")]
    public class ProductModel
    {
        [Key,
         Column("")]
        public int Id { get; set; }

        [Column(""),
         Display(Name = "Name:"),
         Required(ErrorMessage = "Required!")]
        public string? Name { get; set; }

        [Column(""),
         Display(Name = "Characteristics:"),
         Required(ErrorMessage = "Required!")]
        public string? Characteristics { get; set; }

        [Column(""),
         Display(Name = "Midium Price:"),
         Required(ErrorMessage = "Required!")]
        public double MidPrice { get; set; }

        [Column(""),
         Display(Name = "Logo:"),
         Required(ErrorMessage = "Required!")]
        public string? Logo { get; set; }

        [Column(""),
         Display(Name = "Active:"),
         Required(ErrorMessage = "Required!")]
        public bool Active { get; set; }

        public CategoryModel? Category { get; set; }
    }
}
