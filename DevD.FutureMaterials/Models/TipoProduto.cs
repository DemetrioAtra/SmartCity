using System.ComponentModel.DataAnnotations;

namespace DevD.FutureMaterials.Models
{
    public class TipoProduto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatória!"),
         MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!"),
         MinLength(3, ErrorMessage = "Mínimo de 3 caracteres!"),
         Display(Name = "Descrição:")]
        public string? Descricao { get; set; }

        public bool Comercializado { get; set; }
    }
}
