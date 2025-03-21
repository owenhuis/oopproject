using System;
using System.Collections.Generic;

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

            // Voeg 3 Pokéballs met Charmanders toe voor deze trainer
            for (int i = 0; i < 2; i++)
            {
                Belt.Add(new Pokeball(new Charmander("charr")));
                Belt.Add(new Pokeball(new Bulbasaur("bulba")));
            }
        }

        public void TakePokeball(Pokeball pokeball)
        {
            Belt.Add(pokeball);
        }

        public Charmander ThrowPokeball()
        {
            foreach (var pokeball in Belt)
            {
                if (pokeball.HasCharmander())
                {
                    Console.WriteLine($"{Name} gooit een Pokéball!");
                    return pokeball.Open();
                }
            }
            return null;
        }

        public void ReturnPokemon(Charmander charmander)
        {
            foreach (var pokeball in Belt)
            {
                if (!pokeball.HasCharmander())
                {
                    pokeball.Close(charmander);
                    Console.WriteLine($"{Name} roept {charmander.Name} terug in de Pokéball.");
                    break;
                }
            }
        }
    }
}
