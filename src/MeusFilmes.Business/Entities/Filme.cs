using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace MeusFilmes.Business.Entities
{

    public class Filme : BaseClass
    {

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Informe o Título")]
        public string Titulo { get; set; }

        [Display(Name = "Duração")]
        [Required(ErrorMessage = "Informe a Duração")]
        public int Duracao { get; set; }


        [Required(ErrorMessage = "Informe o Ano")]
        public int Ano { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Informe o Gênero")]
        public List<Genero> Generos { get; set; }

        [Required(ErrorMessage = "Informe o Diretor")]
        public List<Pessoa> Diretores { get; set; }

        [Required(ErrorMessage = "Informe o Elenco")]
        public List<Pessoa> Elencos { get; set; }

        [Display(Name = "Mídia")]
        [Required(ErrorMessage = "Informe o Tipo de Mídia")]
        public List<Midia> Midias { get; set; }
    }

}