using System;
using AS2021_TPSIT_4H_SantarsieriAndrea_prontosoccorso.Models;

namespace AS2021_TPSIT_4H_SantarsieriAndrea_prontosoccorso
{
    class Program
    {
        static void Main(string[] args)
        {
            ProntoSoccorso prontoSoccorso = new ProntoSoccorso();

            prontoSoccorso.InserisciPaziente("Prova", "Prova", "prprprprprr", "Rosso", Convert.ToDateTime("2/1/2021"));
            Console.WriteLine($"\tLista pazienti colore:\n{prontoSoccorso.ListaPazientiColore("Rosso")}");
            try
            {
                Console.WriteLine($"\tPaziente Cercato:\n{prontoSoccorso.RecuperoPaziente("prprprprprr")}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(prontoSoccorso.SalvataggioDati());

            if (prontoSoccorso.DimissionePaziente("prprprprprr"))
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Esito dimissioni paziente: {prontoSoccorso.DimissionePaziente("prprprprprr")}");
            Console.ResetColor();

            Console.WriteLine(prontoSoccorso.SalvataggioDati());

            if (prontoSoccorso.EliminazionePaziente("prprprprprr"))
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Esito eliminazione paziente: {prontoSoccorso.EliminazionePaziente("prprprprprr")}");
            Console.ResetColor();

            Console.WriteLine(prontoSoccorso.SalvataggioDati());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ripristinare il file (S/N)?");
            Console.ResetColor();

            if (Console.ReadLine() == "S")
                prontoSoccorso.RipristinaDati();
        }
    }
}
