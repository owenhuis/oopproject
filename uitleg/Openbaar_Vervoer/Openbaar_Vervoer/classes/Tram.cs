using System.Security.Cryptography.X509Certificates;

namespace Openbaar_Vervoer;

public class Tram : Vervoersmiddel
{
    private int aantalOVPaaltjes;

    public Tram(int wielAantal, int plaatsen, int aantalPaaltjes) : base(wielAantal, plaatsen) 
    {
        this.aantalOVPaaltjes = aantalPaaltjes;
    }

    public int getAantalOVPaaltjes() 
    {
        return this.aantalOVPaaltjes;
    }
    
    public void setAantalOVPaaltjes(int aantal)
    {
        this.aantalOVPaaltjes = aantal;
        
    }

}