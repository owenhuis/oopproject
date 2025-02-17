using System;

namespace trein_maken
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void bemanTrein(Train trein)
        {
            // neem controlle over de trein
            trein.giveControl(this);
        }
    }
    public class Train
    {
        public int aantalWielen;
        public int aantalPlaatsen;
        public Person conducteur;
        public Train(int wielAantal, int plaatsAantal)
        {
            this.aantalWielen = wielAantal;
            this.aantalPlaatsen = plaatsAantal;
        }
        public int rijden()
        {
            return 130;
        }
        public int remmen()
        {
            return 0;
        }

        public void giveControl(Person nieuweConducteur)
        {
            this.conducteur = nieuweConducteur;
        }
    }

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
