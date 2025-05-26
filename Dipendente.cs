using System;

public class Dipendente
{
    public string Nome { get; set; }
    private int eta;


    public int Eta { get { return eta; }
        set { if (value >= 18)
                eta = value; }
    };

    public virtual void EseguiCompito()
    {
        Console.WriteLine("Compito Generico del dipendente");
    }

}