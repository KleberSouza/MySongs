using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    public class Musica
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public TimeSpan Duracao { get; set; }

        public DateTime DataLançamento { get; set; }
    }
}
