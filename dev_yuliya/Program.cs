public class Autista : Dipendente
{
    private string Patente;

    public Autista(string Nome, int eta, string patente) : base(Nome, eta)
    {
        Patente = patente;
    }

    public string patente
    {
        get
        {
            return Patente;
        }
        set
        {

        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Guida il veicolo con patente {Patente}");
    }
}

public class Meccanico : Dipendente
{
    private string Specializzazione;

    public Meccanico(string Nome, int eta, string specializzazione) : base(Nome, eta)
    {
        Specializzazione = specializzazione;
    }

    public string specializzazione
    {
        get
        {
            return Specializzazione;
        }
        set
        {

        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Ripara mezzi specializzati in {Specializzazione}");
    }
}

public class OperatoreCentrale : Dipendente
{
    private string Turno;


    public OperatoreCentrale(string Nome, int eta, string turno) : base(Nome, eta)
    {
        Turno = turno;
    }

    public string turno
    {
        get
        {
            return Turno;
        }
        set
        {
            if (value == "giorno" || value == "notte")
            {
                turno = value;
            }
            else
            {
                Console.WriteLine("Turno non valido. Inserire solo 'giorno' o 'notte'.");
            }
        }
    }
    
    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestisce le comunicazioni in turno {Turno}");
    }



}