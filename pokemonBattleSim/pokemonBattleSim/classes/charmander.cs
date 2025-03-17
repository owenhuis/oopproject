using System;

namespace pokemonBattleSim.classes
{
    class Charmander
    {
        public string Nickname { get; private set; }
        public string Strength { get; private set; }
        public string Weakness { get; private set; }

        public Charmander(string nickname, string strength, string weakness)
        {
            Nickname = nickname;
            Strength = strength;
            Weakness = weakness;
        }

        public string GetName()
        {
            return Nickname;
        }

        public string BattleCry()
        {
            return $"{Nickname} roept: CHARRRRR!";
        }
    }
}
