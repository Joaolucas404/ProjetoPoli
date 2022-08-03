using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanto.src
{
    internal class Squirtle : Bulbassauro
    {
        public Squirtle() { }
        public Squirtle(string Nome, int Level, string Tipo) : base(Nome, Level, Tipo)
        {
            Nome = "Squirtle";
            Level = 1;
            Tipo = "Água";
        }
        
        public override void Batalhar()
        {
            Console.WriteLine(
                $"Squirtle, eu Escolho Você!!");
        }

        public void Falar()
        {
            Console.WriteLine($"Squirtle, Squirtle!!");
        }
    }
}