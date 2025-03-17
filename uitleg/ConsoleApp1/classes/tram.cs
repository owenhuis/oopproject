using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.classes
{
    public class Tram : vervoersmiddel
    {
        public int aantalOVPaaltjes;
        public Tram(int wielAantal, int plaatsen, int aantalPaaltjes)
        {
            this.aantalOVPaaltjes = aantalPaaltjes;
        }

        public void giveControl(Person nieuweConducteur)
        {
            this.conducteur = nieuweConducteur;
        }
    }
}
