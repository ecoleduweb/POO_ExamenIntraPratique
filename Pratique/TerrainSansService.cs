namespace Pratique;

public class TerrainSansService : ATerrain
{
    public TerrainSansService() : base(30)
    {
    }

    public override double CalculerCout()
    {
        return Cout;
    }
}
