using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kanto.src;

namespace Pokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokemonss pokemonss = new Pokemonss();
            Console.WriteLine(@"   
                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|");
            
            Console.Write("-- Escolha o Seu pokemon para Batalhar --\n" +
              "0 - Bulbassauro\n" +
              "1 - Pikachu\n" +
              "2 - Squirtle\n" +
              "Digite a opção escolhida: ");
            int SelctPoke = int.Parse(Console.ReadLine());
            switch (SelctPoke)
            { 
             case 0:
                    Console.WriteLine(@"
                        _,.------....___,.' ',.-.
                     ,-'          _,.--""        |
                   ,'         _.-'              .
                  /   ,     ,'                   `
                 .   /     /                     ``.
                 |  |     .                       \.\
       ____      |___._.  |       __               \ `.
     .'    `---""""       ``""-.--""'`  \               .  
    .  ,            __               `              |   .
    `,'         ,-""'  .               \             |    L
   ,'          '    _.'                -._          /    |
  ,`-.    ,"".   `--'                      >.      ,'     |
 . .'\'   `-'       __    ,  ,-.         /  `.__.-      ,'
 ||:, .           ,'  ;  /  / \ `        `.    .      .'/
 j|:D  \          `--'  ' ,'_  . .         `.__, \   , /
/ L:_  |                 .  ""' :_;                `.'.'
.    """"'                  """"""""""'       
 `.                                 .    `.   _,..  `
   `,_   .    .                _,-'/    .. `,'   __  `
    ) \`._        ___....----""'  ,'   .'  \ |   '  \  .
   /   `. ""`-.--""'         _,' ,'     `---' |    `./  |
  .   _  `""""'--.._____..--""   ,             '         |
  | ."" `. `-.                /-.           /          ,
  | `._.'    `,_            ;  /         ,'          .
 .'          /| `-.        . ,'         ,           ,
 '-.__ __ _,','    '`-..___;-...__   ,.'\ ____.___.'
 `""^--'..'   '-`-^-'""--    `-^-'`.''""""""""""`.,^.`.--'");
               Bulbassauro Bulbassauro = new Bulbassauro();
                    Bulbassauro.Falar();
                    Bulbassauro.Batalhar();
             break;
                        
            }
        }



    }
}