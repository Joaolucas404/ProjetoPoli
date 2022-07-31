using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanto.src
{
     class Pokemonss
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public string Tipo { get; set; }
        public Pokemonss(string nome, int level, string tipo)
        {
            Nome = nome;
            Level = level;
            Tipo = tipo;
        }
        public Pokemonss() { }
        public virtual void Batalhar()
        {
            Console.WriteLine($"\n-- Ação --\n" +
                $"Pokemon eu Escolho Você");
        }

    }
}
