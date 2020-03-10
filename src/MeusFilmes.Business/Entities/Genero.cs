using System.ComponentModel.DataAnnotations;

namespace MeusFilmes.Business.Entities
{
    public class Genero
    {
         [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Informe o Gênero")]
        public string Nome { get; set; }

    }
}