using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSim.classes
{
    class Charmander
    {
        public string pokemon;
        public string type;
        public string weakness;
        public string naam;

        public Charmander(string pokemon, string type, string weakness, string naam)
        {
            this.pokemon = pokemon;
            this.type = type;
            this.weakness = weakness;
            this.naam = naam;
        }
    }
}
