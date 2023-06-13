using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStack.Shared
{
    public class SuperHero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string FisrtName { get; set; } = string.Empty;
        [Required(ErrorMessage = "O Sobrenome é obrigatório!")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "O Nome do Heroi é obrigatório!")]
        public string HeroName { get; set; } = string.Empty;
        public int ComicId { get; set; }
        public Comic? Comic{ get; set;}

    }
}
