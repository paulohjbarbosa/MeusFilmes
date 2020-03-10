using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeusFilmes.Business.Entities
{
    public abstract class BaseClass
    {
        [Key]
        public virtual int Id { get; set; }
    }
}