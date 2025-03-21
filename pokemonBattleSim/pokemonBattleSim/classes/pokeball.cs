namespace pokemonBattleSim.classes
{
    class Pokeball
    {
        // charmander pokeball check
        public Pokemon pokemon;
        public bool HasPokemonInside;

        public Pokeball(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            HasPokemonInside = true;
        }

        public Charmander Open()
        {
            if (HasPokemonInside)
            {
                HasPokemonInside = false;
                return pokemon;
            }
            return null;
        }

        public void Close(Charmander charmander)
        {
            this.pokemon = charmander;
            HasPokemonInside = true;
        }

        public bool HasCharmander()
        {
            return HasPokemonInside;
        }

    }
}
