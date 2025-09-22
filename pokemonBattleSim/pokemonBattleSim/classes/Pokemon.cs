using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSim.classes
{
    public class Pokemon
    {
        public string Name;
        public string Nickname;
        public string Strength;
        public string Weakness;

        public Pokemon(string nickname, string strength, string weakness, string name)
        {
            Nickname = nickname;
            Strength = strength;
            Weakness = weakness;
            Name = name;
        }

        public string BattleCry()
        {
            return $"{Name} roept: {Nickname}!";
        }
    }
}
