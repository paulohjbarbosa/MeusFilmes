using System.ComponentModel.DataAnnotations;

namespace MeusFilmes.Business.Entities
{
    public class Midia
    {
        
        [Display(Name = "Mídia")]
        [Required(ErrorMessage = "Informe a Mídia")]
        public string Nome { get; set; }
    }
}