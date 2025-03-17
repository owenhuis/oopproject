using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Train : vervoersmiddel
    {
        public Train(int wielAantal, int plaatsAantal)
        {
            this.aantalWielen = wielAantal;
            this.aantalPlaatsen = plaatsAantal;
        }

        public void giveControl(Person nieuweConducteur)
        {
            this.conducteur = nieuweConducteur;
        }

    }
}
