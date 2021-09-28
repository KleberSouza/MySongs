using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome")]
        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }
    }
}
