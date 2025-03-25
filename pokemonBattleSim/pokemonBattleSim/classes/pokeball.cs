namespace pokemonBattleSim.classes
{
    class Pokeball
    {
        
        public Pokemon pokemon;
        public bool HasPokemonInside;

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
            this.pokemon = pokemon;
            HasPokemonInside = true;
        }

        public bool HasPokemon()
        {
            return HasPokemonInside;
        }

    }
}
