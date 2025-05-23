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
}
