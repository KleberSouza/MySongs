using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    [Table("Grupos")]
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Líder")]
        [Required(ErrorMessage = "Obrigatório informar o líder!")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Lider { get; set; }
    }
}
