using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanto.src
{
    class Pikachu : Pokemonss
    {
        public Pikachu() { }
        public Pikachu(string Nome, int Level, string Tipo) : base(Nome, Level, Tipo)
        {
            Nome = "Pikachu";
            Level = 3;
            Tipo = "Elétrico";
        }
        public override void Batalhar()
        {
            Console.WriteLine(
                $"Pikachu, eu Escolho Você!!");
        }
        
        public static void Falar()
        {
            Console.WriteLine($"pika,pika!!");
        }


    }
}

