using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanto.src
{
    class Pikachu : Bulbassauro
    {
        public Pikachu(string Nome, int Level, string Tipo) : base(Nome, Level, Tipo)
        {
            Nome = "Pikachu";
            Level = 3;
            Tipo = "Elétrico";
        }
        public override void Batalhar()
        {
            Console.WriteLine($"\n-- Ação --\n" +
                $"Pikachu eu Escolho Você");
        }
        
        public void Falar()
        {
            Console.WriteLine($"pika,pika");
        }


    }
}

