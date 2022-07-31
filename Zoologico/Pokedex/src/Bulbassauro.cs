using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanto.src
{
    class Bulbassauro : Pokemonss
    {
        public Bulbassauro() { }
        public Bulbassauro(string Nome, int Level, string Tipo) : base(Nome, Level, Tipo)
        {
            Nome = "Bulbassauro";
            Level = 5;
            Tipo = "Planta";
        }

        public override void Batalhar()
        {
            Console.WriteLine($"\n-- Ação --\n" +
                $"Bulbassauro eu Escolho Você!!");
        }
        public void Falar()
        {
            Console.WriteLine($"Bulbassaur,Bulbassaur");
        }
    }
}