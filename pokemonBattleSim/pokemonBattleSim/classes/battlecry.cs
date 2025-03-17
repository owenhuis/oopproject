using System;

namespace pokemonBattleSim.classes
{
    class Battlecry
    {
        public Battlecry(string pokemon)
        {
            Console.WriteLine($"Welke naam wil je geven aan {pokemon}?");
            string naam = Console.ReadLine();

            // Zorg ervoor dat er een geldige naam is
            while (string.IsNullOrWhiteSpace(naam))
            {
                Console.WriteLine("Je moet een naam invoeren. Probeer opnieuw:");
                naam = Console.ReadLine();
            }

            Console.WriteLine($"{pokemon} roept!");

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(naam);
                }

                Console.WriteLine("Wil je een andere naam geven? (ja/nee)");
                string keuze = Console.ReadLine()?.ToLower() ?? "";

                if (keuze == "nee")
                {
                    break;
                }
                if (keuze == "ja")
                {
                    Console.WriteLine($"Welke nieuwe naam wil je geven aan {pokemon}?");
                    string nieuweNaam = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nieuweNaam))
                    {
                        naam = nieuweNaam;
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer, de naam blijft ongewijzigd.");
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige invoer. Voer 'ja' of 'nee' in.");
                }
            }
        }
    }
}
