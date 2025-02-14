using System;

namespace pokemonBattleSim
{
    class Charmander
    {
        public string pokemon;
        public string type;
        public string weakness;
        public string naam;

        public Charmander(string pokemon, string type, string weakness, string naam)
        {
            this.pokemon = pokemon;
            this.type = type;
            this.weakness = weakness;
            this.naam = naam;
        }

        public void battlecry()
        {
            Console.WriteLine("Charmander roept!");

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(this.naam);
                }

                Console.WriteLine("Wil je een andere naam geven? (ja/nee)");
                string keuze = Console.ReadLine().ToLower();

                if (keuze == "nee")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Welke nieuwe naam wil je geven aan Charmander?");
                    this.naam = Console.ReadLine();
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Je hebt een Charmander ontvangen!");
            Console.WriteLine("Welke naam wil je geven aan Charmander?");
            string naam = Console.ReadLine();

            Charmander pokémon = new Charmander("Charmander", "Fire", "Water", naam);

            Console.WriteLine("Je hebt een " + pokémon.pokemon + "met de naam " + pokémon.naam + "Dat is een "+ pokémon.type + "type en is zwak tegen" + pokémon.weakness+ "type.");

            pokémon.battlecry();
        }
    }
}
