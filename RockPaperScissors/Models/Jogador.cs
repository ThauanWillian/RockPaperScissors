using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class Jogador
    {
        public string Nome { get; set; }
        public int JogadaKey { get; set; }
        public string JogadaValue { get; set; }
        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}
