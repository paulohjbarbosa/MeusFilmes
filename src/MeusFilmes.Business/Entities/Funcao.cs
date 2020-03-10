using System.ComponentModel.DataAnnotations;

namespace MeusFilmes.Business.Entities
{
    public class Funcao
    {
        [Display(Name = "Função")]
        [Required(ErrorMessage = "Informe a Função")]
        public string Nome { get; set; }

    }
}