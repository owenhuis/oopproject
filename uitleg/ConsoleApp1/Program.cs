using System;
using ConsoleApp1.classes;

namespace trein_maken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persoon1 = new Person(firstName: "kees", lastName: "panda", age: 3);

            Train eersteTrein = new Train(wielAantal:7, plaatsAantal:30);
            Train tweedeTrein = new Train(wielAantal: 18, plaatsAantal: 36);

            persoon1.bemanTrein(eersteTrein);

            Console.WriteLine(eersteTrein.conducteur.firstName);

            Console.WriteLine(eersteTrein.aantalWielen);
            Console.WriteLine(eersteTrein.aantalPlaatsen);
            Console.WriteLine(eersteTrein.conducteur);
            Console.WriteLine();
            Console.WriteLine(tweedeTrein.aantalWielen);
            Console.WriteLine(tweedeTrein.aantalPlaatsen);
            Console.WriteLine(tweedeTrein.conducteur);
            Console.WriteLine();
            Console.WriteLine("hello world!");
        }
    }
}
