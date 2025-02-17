using System;
using pokemonBattleSim.classes;

namespace pokemonBattleSim
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Je hebt een Charmander ontvangen!");
            Console.WriteLine("Welke naam wil je geven aan Charmander?");
            string naam = Console.ReadLine();

            Charmander pokémon = new Charmander("Charmander", "Fire", "Water", naam);

            Console.WriteLine("Je hebt een " + pokémon.pokemon + "met de naam " + pokémon.naam + "Dat is een " + pokémon.type + "type en is zwak tegen" + pokémon.weakness + "type.");

            Battlecry battlecry = new Battlecry(pokémon.pokemon, pokémon.naam);

        }
    }
}