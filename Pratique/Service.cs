
namespace Pratique;

public class Service
{
    private double Cout;
    private bool EstActif;
    private string Nom;
    public Service(double cout, bool estActif, string nom)
    {
        Nom = nom;
        Cout = cout;
        EstActif = estActif;
    }

    public double GetCout()
    {
        return Cout;
    }

    public bool GetEstActif()
    {
        return EstActif;
    }
}
