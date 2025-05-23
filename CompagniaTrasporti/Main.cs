using System;

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
            Console.WriteLine($"Nome: {dip.Nome}, Turno: {dip.Turno}, Tipo: {dip.GetType().Name}");
        }
    }
}