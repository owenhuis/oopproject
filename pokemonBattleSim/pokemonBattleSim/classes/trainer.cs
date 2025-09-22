using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading;
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
        public Pokemon ThrowPokeball(bool challenger, bool opponent)
        {
            int ball_count = 0;
            string gekozen_pokemon = "test";
            while (true) {
                if (challenger == true)
                {
                    Console.WriteLine("welke pokemon kies jij (charmander/bulbasaur/squirtle)");
                    gekozen_pokemon = Console.ReadLine();
                }
                if (opponent == true)
                {
                    Thread.Sleep(1000);
                    List<string> pokelijst = new List<string> { "bulbasaur", "charmander", "squirtle" };
                    Random rnd = new Random();
                    int index = rnd.Next(pokelijst.Count);
                    gekozen_pokemon = pokelijst[index];

                }
                
                foreach (Pokeball p in Belt)
                {


                    if (p.HasPokemon())
                    {
                        Pokemon mon = p.pokemon;

                        if (mon.Name.ToLower() == gekozen_pokemon.ToLower())
                        {
                            Console.WriteLine($"{Name} gooit een Pokéball!");
                            return p.Open();
                        }
                    }
                    ball_count++;

                }

                if (challenger)
                {
                    Console.WriteLine("deze pokemon zijn al gerbruikt kies een andere");
                }
                if (ball_count == 12)
                {
                    Console.WriteLine("1 van de trainers heeft geen pokéballs meer");
                    return null;
                }

            }
        }

        public void ReturnPokemon(Pokemon pokemon, bool keep)
        {
            foreach (var pokeball in Belt)
            {
                if (!pokeball.HasPokemon())
                {
                    pokeball.Close(pokemon);
                    if (!keep)
                    {
                        Belt.Remove(pokeball);
                    }
                    Console.WriteLine($"{Name} roept {pokemon.Name} terug in de Pokéball.");
                    break;
                }
            }
        }
    }
}
