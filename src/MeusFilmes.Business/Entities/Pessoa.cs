using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeusFilmes.Business.Entities
{
    public class Pessoa
    {
        

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        public List<Funcao> Funcoes { get; set; }
    }
}