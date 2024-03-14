namespace Pratique;

public class TerrainSauvage : ATerrain
{
    public TerrainSauvage() : base(30)
    {
    }

    public override double CalculerCout()
    {
        return Cout;
    }
}
