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
        private string Name { get; }
        private string Nickname { get; set; }
        private type Strength;
        private type Weakness;

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
