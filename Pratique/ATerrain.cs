namespace Pratique;

public abstract class ATerrain
{
    protected double Cout;

    public ATerrain(double cout)
    {
        Cout = cout;
    }

    public abstract double CalculerCout();
}
