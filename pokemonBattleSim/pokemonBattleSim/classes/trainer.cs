using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Xml.Linq;

namespace pokemonBattleSim.classes
{
    class Trainer
    {
        public string Name;
        public List<Pokeball> Belt;
        private Pokemon gekozen_pokemon;

        public Trainer(string name)
        {
            Name = name;
            Belt = new List<Pokeball>();
            for (int i = 0; i < 6; i++)
            {
                if (Belt.Count < 2)
                {
                    Belt.Add(new Pokeball(new Charmander("charr")));
                }
                else if (Belt.Count < 4 && Belt.Count >= 2)
                {
                    Belt.Add(new Pokeball(new Bulbasaur("bulba")));
                }
                else if (Belt.Count >= 4)
                {
                    Belt.Add(new Pokeball(new Squirtle("squirt")));
                }
                
            }
        }
        public Pokemon ThrowPokeball(bool challenger, bool opponent)
        {
            if (challenger == true)
            {
                Console.WriteLine("welke pokemon kies jij (charmander/bulbasaur/squirtle)");
                string gekozen_pokemon = Console.ReadLine();
            }
            if (opponent == false)
            {
                List<string> pokelijst = new List<string> { "bulbasaur", "charmander", "squirtle" };
                Random rnd = new Random();
                int index = rnd.Next(pokelijst.Count);
                string gekozen_pokemon = pokelijst[index];

            }

            foreach (Pokemon p in Belt)
            {

                if (p ==  gekozen_pokemon)
                {
                    Console.WriteLine($"{Name} gooit een Pokéball!");
                    return p.Open();
                }
            }
            return null;
        }

        public void ReturnPokemon(Pokemon pokemon)
        {
            foreach (var pokeball in Belt)
            {
                if (!pokeball.HasPokemon())
                {
                    pokeball.Close(pokemon);

                    Belt.Remove(pokeball);
                    Console.WriteLine($"{Name} roept {pokemon.Name} terug in de Pokéball.");
                    break;
                }
            }
        }
    }
}
