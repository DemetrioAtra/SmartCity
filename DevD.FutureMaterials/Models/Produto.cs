using System.ComponentModel.DataAnnotations;

namespace DevD.FutureMaterials.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório!"),
         MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!"),
         MinLength(3, ErrorMessage = "Mínimo de 3 caracteres!"),
         Display(Name = "Nome:")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório!"),
         MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!"),
         MinLength(3, ErrorMessage = "Mínimo de 3 caracteres!"),
         Display(Name = "Características:")]
        public string? Caracteristica { get; set; }

        [Display(Name = "Preço Médio:")]
        public double PrecoMedio { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!"),
         Display(Name = "Logotipo:")]
        public string? Logotipo { get; set; }

        [Display(Name = "Ativo:")]
        public bool Ativo { get; set; }

        public TipoProduto? Tipo { get; set; }
    }
}
