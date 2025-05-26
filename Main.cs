using System;

public class Dipendente
{
    private string nome;
    private int eta;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Eta
    {
        get { return eta; }
        set
        {
            if (value >= 18)
                eta = value;
        }
    }

    public virtual string EseguiCompito()
    {
        return "Compito Generico del dipendente";
    }

}

public class Autista : Dipendente
{
    public Autista(string nome, int eta, string patente)
    {
        Nome = nome;
        Eta = eta;
        Patente = patente;
    }

    public string Patente { get; set; }

    public override string EseguiCompito()
    {
        return $"Guida il veicolo con patente {Patente}";
    }
}

public class Meccanico : Dipendente
{
    public Meccanico(string nome, int eta, string specializzazione)
    {
        Nome = nome;
        Eta = eta;
        Specializzazione = specializzazione;
    }

    public string Specializzazione { get; set; }

    public override string EseguiCompito()
    {
        return $"Ripara mezzi specializzati in {Specializzazione}";
    }
}

public class OperatoreCentrale : Dipendente
{
    private string turno;

    public OperatoreCentrale(string nome, int eta, string turno)
    {
        Nome = nome;
        Eta = eta;
        Turno = turno;
    }

    public string Turno
    {
        get
        {
            return turno;
        }
        set
        {
            if (value.ToLower() == "giorno" || value.ToLower() == "notte")
            {
                turno = value;
            }
            else
            {
                Console.WriteLine("Turno non valido. Inserire solo 'giorno' o 'notte'.");
            }
        }
    }

    public override string EseguiCompito()
    {
        return $"Gestisce le comunicazioni in turno {Turno}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        bool esci = false;
        int scelta;
        List<Dipendente> dipendenti = new List<Dipendente>();

        do
        {
            Console.WriteLine("Benvenuto. Cosa vuoi fare?");
            Console.WriteLine("[1] Aggiungi autista\n[2] Aggiungi meccanico\n[3] Aggiungi operatore centrale");
            Console.WriteLine("[4] Visualizza tutti i dipendenti\n[5] Fai eseguire i compiti ai dipendenti\n[0] Esci");
            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    AggiungiAutista(dipendenti);
                    break;
                case 2:
                    AggiungiMeccanico(dipendenti);
                    break;
                case 3:
                    AggiungiOperatore(dipendenti);
                    break;
                case 4:
                    StampaDipendenti(dipendenti);
                    break;
                case 5:
                    Compito(dipendenti);
                    break;
                case 0:
                    esci = true;
                    Console.WriteLine("Arrivederci campione!");
                    break;
                default:
                    Console.WriteLine("ERRORE INPUT - Ritorno al menù.");
                    break;
            }
        } while (!esci);
    }

    private static void AggiungiAutista(List<Dipendente> dipendenti)
    {
        Console.WriteLine("Inserisci il nome dell'autista:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quanti anni ha?");
        int eta = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci la patente dell'autista:");
        string patente = Console.ReadLine();

        Autista autista = new Autista(nome, eta, patente);
        dipendenti.Add(autista);

        Console.WriteLine("Autista inserito!");
    }

    private static void AggiungiMeccanico(List<Dipendente> dipendenti)
    {
        Console.WriteLine("Inserisci il nome del meccanico:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quanti anni ha?");
        int eta = int.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci la specializzazione dell'autista:");
        string specializzazione = Console.ReadLine();

        Meccanico meccanico = new Meccanico(nome, eta, specializzazione);
        dipendenti.Add(meccanico);

        Console.WriteLine("Meccanico inserito!");
    }

    private static void AggiungiOperatore(List<Dipendente> dipendenti)
    {
        Console.WriteLine("Inserisci il nome del meccanico:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quanti anni ha?");
        int eta = int.Parse(Console.ReadLine());
        Console.WriteLine("Che turno fa? (Giorno/Notte)");
        string turno = Console.ReadLine();

        OperatoreCentrale operatore = new OperatoreCentrale(nome, eta, turno);
        dipendenti.Add(operatore);

        Console.WriteLine("Operatore centrale inserito!");
    }

    private static void StampaDipendenti(List<Dipendente> dipendenti)
    {
        foreach (Dipendente dip in dipendenti)
        {
            Console.WriteLine($"Nome: {dip.Nome}, Eta: {dip.Eta}, Tipo: {dip.GetType().Name}");
        }
    }

    private static void Compito(List<Dipendente> dipendenti)
    {
        foreach (Dipendente dip in dipendenti)
        {
            Console.WriteLine(dip.EseguiCompito());
        }
    }
}