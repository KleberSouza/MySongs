using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySongs.Models
{
    public class Artista
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Nacionalidade { get; set; }
    }
}
