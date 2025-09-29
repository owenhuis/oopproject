using System.Threading;

namespace pokemonBattleSim.classes
{
    class Pokeball
    {
        
        public Pokemon pokemon { get; private set; }
        public bool HasPokemonInside { get; private set; }

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            HasPokemonInside = true;
        }

        public Pokemon Open()
        {
            if (HasPokemonInside)
            {
                HasPokemonInside = false;
                return pokemon;
            }
            return null;
        }
        
        public void Close(Pokemon pokemon)
        {
            Thread.Sleep(1000);
            this.pokemon = pokemon;
            HasPokemonInside = true;
        }

        public bool HasPokemon()
        {
            return HasPokemonInside;
        }

    }
}
