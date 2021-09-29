using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    [Table("Musicas")]
    public class Musica
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "Duração")]
        [Required(ErrorMessage = "Obrigatório informar a duração!")]
        public TimeSpan Duracao { get; set; }

        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "Obrigatório informar a data de lançamento!")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Obrigatório informar o gênero!")]
        public int GeneroId { get; set; }

        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }
    }
}
