namespace pokemonBattleSim.classes
{
    class Pokeball
    {
        private Charmander charmander;
        public bool HasCharmanderInside { get; private set; }

        public Pokeball(Charmander charmander)
        {
            this.charmander = charmander;
            HasCharmanderInside = true;
        }

        public Charmander Open()
        {
            if (HasCharmanderInside)
            {
                HasCharmanderInside = false;
                return charmander;
            }
            return null;
        }

        public void Close(Charmander charmander)
        {
            this.charmander = charmander;
            HasCharmanderInside = true;
        }

        public bool HasCharmander()
        {
            return HasCharmanderInside;
        }
    }
}
