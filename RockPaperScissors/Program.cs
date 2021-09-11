using RockPaperScissors.Models;
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Thauan");
            Jogador j2 = new Jogador("Willian");
            Maquina machine = new Maquina();

            Console.Write(machine.FinalResult(j1, j2));
        }
    }
}
