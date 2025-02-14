using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSim
{
    internal class Program
    {

        



        static void Main(string[] args)
        {
            Console.WriteLine("je hebt een charmander");

            while (true)
            {
                Console.WriteLine("wat voor naam wil je geven aan charmander");
                string naam = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(naam);
                }
                Console.WriteLine("wil je een andere naam? (ja/nee)");
                string keuze = Console.ReadLine();
                if (keuze == "nee")
                {
                    break;
                }
            }
        }
    }
}
