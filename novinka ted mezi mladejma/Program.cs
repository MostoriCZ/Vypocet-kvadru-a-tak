using Spectre.Console
;
public class Kvadr
{
    public Kvadr(float a, float b, float c)
    {
        A = a; B = b; C = c;
    }

    public float A { get; set; }
    public float B { get; set; }
    public float C { get; set; }

    public double VypocetObjemu()
    {
        return A * B * C;
    }
    public double VypocetPovrchu()
    {
        return 2 * (A * B + B * C + C * A);
    }
    public double T_Uhlopricka()
    {
        return Math.Round(Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)), 2);
    }

    public double S_Uhlopricka()
    {
        return Math.Round(Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)), 2);
    }
    public static void Main()
    {
        var input1 = AnsiConsole.Ask<float>("Velikost strany A: ");
        var input2 = AnsiConsole.Ask<float>("Velikost strany B: ");
        var input3 = AnsiConsole.Ask<float>("Velikost strany C: ");

        var kostka = new Kvadr(input1, input2, input3);
        Console.Write("úhlopříčka je: " + kostka.S_Uhlopricka() +" Tělesová úhlopříčka je: "+ kostka.T_Uhlopricka() +" Výpočet povrchu je: "+ kostka.VypocetPovrchu() + " Výpočet objemu je: " + kostka.VypocetObjemu());
    }

}