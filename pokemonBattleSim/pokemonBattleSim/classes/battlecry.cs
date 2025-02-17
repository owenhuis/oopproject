using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSim.classes
{
    class Battlecry
    {
        public Battlecry(string pokemon, string naam)
            {
                Console.WriteLine(pokemon + " roept!");

                while (true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(naam);
                    }

                    Console.WriteLine("Wil je een andere naam geven? (ja/nee)");
                    string keuze = Console.ReadLine().ToLower();

                    if (keuze == "nee")
                    {
                        break;
                    }
                    if (keuze == "ja")
                    {
                        Console.WriteLine("Welke nieuwe naam wil je geven aan Charmander?");
                        naam = Console.ReadLine();
                    }
                }
            }
    }
}
