using System;
using System.Collections.Generic;

namespace pokemonBattleSim.classes
{
    class Trainer
    {
        public string Name { get; private set; }
        public List<Pokeball> Belt { get; private set; }

        public Trainer(string name)
        {
            Name = name;
            Belt = new List<Pokeball>();

            // Voeg 3 Pokéballs met Charmanders toe voor deze trainer
            for (int i = 0; i < 3; i++)
            {
                Belt.Add(new Pokeball(new Charmander("Charmander", "Fire", "Water")));
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
                    Console.WriteLine($"{Name} roept {charmander.GetName()} terug in de Pokéball.");
                    break;
                }
            }
        }
    }
}
