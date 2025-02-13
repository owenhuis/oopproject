using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trein_maken
{

    class Train
    {
        public int aantalWielen;
        public int aantalPlaatsen;
        public string conducteur;
        
        public Train(int wielAantal, int plaatsAantal, string conducteurNaam)
        {
            this.aantalWielen = wielAantal;
            this.aantalPlaatsen = plaatsAantal;
            this.conducteur = conducteurNaam;
        }
        public int rijden()
        {
            return 130;
        }
        public int remmen()
        {
            return 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Train eersteTrein = new Train(wielAantal:7, plaatsAantal:30, conducteurNaam:"Eugene");
            Train tweedeTrein = new Train(wielAantal: 18, plaatsAantal: 36, conducteurNaam: "Henk");

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
