using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    class Maquina
    {
        Dictionary<int, string> listDic = new Dictionary<int, string>() { { 1, "Pedra" }, { 2, "Papel" }, { 3, "Tesoura" } };
        public string FinalResult(Jogador j1, Jogador j2)
        {
            AnalysisPlay(j1);
            AnalysisPlay(j2);
            switch (j1.JogadaKey, j2.JogadaKey)
            {
                case (1, 3):
                case (2, 1):
                case (3, 2):
                    return $"O jogador {j1.Nome} venceu com {j1.JogadaValue} contra {j2.JogadaValue}";
                    break;
                case (1, 2):
                case (2, 3):
                case (3, 1):
                    return $"O jogador {j2.Nome} venceu com {j2.JogadaValue} contra {j1.JogadaValue}";
                    break;
                default:
                    return $"Empate! Ambos jogadores usaram {j1.JogadaValue}!";
                    break;
            }
            return String.Empty;
        }
        private void AnalysisPlay(Jogador player)
        {
            player.JogadaKey = new Random().Next(3) + 1;
            foreach (KeyValuePair<int, string> indice in listDic)
            {
                if (indice.Key == player.JogadaKey)
                {
                    player.JogadaValue = indice.Value;
                    break;
                }
            }
        }
    }
}
