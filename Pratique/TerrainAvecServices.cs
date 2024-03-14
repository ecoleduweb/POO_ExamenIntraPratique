namespace Pratique;

public class TerrainAvecServices : ATerrain
{
    private Service[] Services = new Service[2];


    public TerrainAvecServices(Service[] services) : base(45)
    {
        Services = services;
    }


    public override double CalculerCout()
    {
        double total = Cout;
        for (int i = 0; i < Services.Length; i++)
        {
            if (Services[i].GetEstActif())
            {
                total += Services[i].GetCout();
            }
        }
        return total;
    }
}
