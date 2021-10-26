using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    [Table("Eventos")]
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessage = "Obrigatório informar o data!")]
        public DateTime Data { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar o descrição!")]
        public string Descricao { get; set; }

        [Display(Name = "Grupo 1")]
        [Required(ErrorMessage = "Obrigatório informar o grupo 1!")]
        public int Grupo1Id { get; set; }

        [ForeignKey("Grupo1Id")]
        public Grupo Grupo1 { get; set; }

        [Display(Name = "Grupo 2")]
        [Required(ErrorMessage = "Obrigatório informar o grupo 1!")]
        public int Grupo2Id { get; set; }

        [ForeignKey("Grupo2Id")]
        public Grupo Grupo2 { get; set; }

    }
}
