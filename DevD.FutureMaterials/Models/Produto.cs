using System.ComponentModel.DataAnnotations;

namespace DevD.FutureMaterials.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório!"),
         MaxLength(30, ErrorMessage = "Máximo de 30 caracteres!"),
         MinLength(2, ErrorMessage = "Mínimo de 2 caracteres!"),
         Display(Name = "Nome:")]
        public string? Nome { get; set; }

        public string? Caracteristica { get; set; }

        public double PrecoMedio { get; set; }

        public string? Logotipo { get; set; }

        public bool Ativo { get; set; }

        public TipoProduto? Tipo { get; set; }
    }
}
