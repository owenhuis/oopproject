using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSim.classes
{
    public enum type { 
        grass,
        fire,
        water
        }
    public class Pokemon
    {
        public string Name { get; }
        public string Nickname { get; }
        public type Strength { get; }
        public type Weakness { get; }

        public Pokemon(string nickname, type strength, type weakness, string name)
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
