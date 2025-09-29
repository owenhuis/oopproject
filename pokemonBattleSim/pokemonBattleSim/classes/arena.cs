using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleSim.classes
{
    internal class Arena
    {
        public int ronde_Count = 1;
        public int battle_Count = 0;
        public Arena(Trainer challenger, Trainer opponnent)
        {
            for (int i = 0; i < ronde_Count; i++)
            {

                Battle fight = new Battle(challenger, opponnent);
                ronde_Count = fight.Fight(ronde_Count);

                battle_Count++;
            }
        }
    }
}
