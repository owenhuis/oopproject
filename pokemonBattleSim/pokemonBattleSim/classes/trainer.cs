using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace pokemonBattleSim.classes
{
    class Trainer
    {
        public string Name;
        public List<Pokeball> Belt;

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
        public Pokemon ThrowPokeball()
        {
            foreach (var pokeball in Belt)
            {
                if (pokeball.HasPokemon())
                {
                    Console.WriteLine($"{Name} gooit een Pokéball!");
                    return pokeball.Open();
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
