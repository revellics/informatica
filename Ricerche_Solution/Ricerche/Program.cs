using System;

namespace Correzione
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //VL al Main
            int scelta = 0;
            string x = string.Empty;
            do
            {
                visualizzaMenu();
                Console.Write("Scelta ==> ");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {

                    case 1:
                        Console.WriteLine("ESERCIZIO 1");
                        string[] nomi_1 = new string[] {"Racca","Atanasov","Picco","Bergese","Calvo",
                            "Cannella","Capatti","Chiarena","Cojocaru","Kitanovski","Gaidano","Gallo",
                            "Ingargiola","Tripi","Manova","Mayam","Azzolina","Allione","Revello",
                            "Sona","Soster","Taricco","Drago","Voinovski"};
                        stampaElenco(nomi_1);
                        Console.Write("Inseisci il nome da cercare: ");
                        x = Console.ReadLine();
                        RicSeqDisorDisg(nomi_1, x);
                        break;

                    case 2:
                        Console.WriteLine("ESERCIZIO 2");
                        string[] nomi_2 = new string[] {"Racca","Atanasov","Picco","Picco","Bergese","Picco","Picco","Bergese","Picco","Picco","Calvo",
                            "Cannella","Capatti","Chiarena","Atanasov","Cojocaru","Kitanovski","Gaidano","Gallo",
                            "Ingargiola","Tripi","Atanasov","Manova","Gallo","Mayam","Azzolina","Gallo","Allione","Revello",
                            "Sona","Soster","Taricco","Gallo","Drago","Voinovski"};
                        stampaElenco(nomi_2);
                        Console.Write("Inseisci il nome da cercare: ");
                        x = Console.ReadLine();
                        RicSeqDisorNDisg(nomi_2, x);
                        break;

                    case 3:
                        Console.WriteLine("ESERCIZIO 1");
                        string[] nomi_3 = new string[] {"Allione","Atanasov","Azzolina","Bergese","Calvo",
                            "Cannella","Capatti","Chiarena","Cojocaru","Drago","Gaidano","Gallo",
                            "Ingargiola","Kitanovski","Manova","Mayam", "Picco","Racca","Revello",
                            "Sona","Soster","Taricco","Tripi","Voinovski"};
                        stampaElenco(nomi_3);
                        Console.Write("Inseisci il nome da cercare: ");
                        x = Console.ReadLine();
                        RicSeqOrdDisg(nomi_3, x);
                        break;

                    case 0:
                        Console.WriteLine("Uscita");
                        break;
                }
                if (scelta != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Premi un tasto");
                    Console.ReadKey();
                }
            }
            while (scelta != 0);
        }

        static void RicSeqOrdDisg(string[] nomi, string x)
        {
            int i = 0;
            int n = nomi.Length;
            while (nomi[i].CompareTo(x) < 0 && i != n - 1)
                i++;
            if (nomi[i] == x)
                Console.WriteLine($"{x} trovato in posizione {i}");
            else
                Console.WriteLine("Non trovato");
        }

        static void RicSeqDisorNDisg(string[] nomi, string x)
        {
            bool t = false;
            for(int i = 0; i < nomi.Length; i++)
            {
                if(nomi[i] == x)
                {
                    Console.WriteLine($"{x} trovato in posizione {i}");
                    Console.WriteLine("è belle che fatto");
                    t = true;
                }
            }
            if (!t)
            {
                Console.WriteLine("Non trovato");
                Console.WriteLine("non è belle che fatto");
            }
        }
        static void RicSeqDisorDisg(string[] nomi, string x)
        {
            int i = 0;
            int n = nomi.Length;
            while (nomi[i] != x && i != n - 1)
                i++;
                if (nomi[i] == x)
                    Console.WriteLine($"{x} trovato in posizione {i}");
                else
                    Console.WriteLine("Non trovato");
        }
        static void stampaElenco(string[] nomi)
        {
            for (int i = 0; i < nomi.Length; i++)
            {
                Console.WriteLine($"--> {i}: {nomi[i]}");
            }
        }
        //}
        //private static void caricaVettoreDisgiunto(int[] v)
        //{
        //    int x, j;
        //    v[0] = generaNCasuale(1, 100);
        //    for (int i = 1; i < v.Length; i++)
        //    {
        //        do
        //        {
        //            x = generaNCasuale(1, 100);
        //            j = 0;
        //            while (x != v[j] && j != i - 1)
        //                j++;
        //            if (x != v[j])
        //                v[i] = x;
        //        }
        //        while (x == v[j]);
        //    }
        //}
        //private static void caricaVettoreOrdinatoCrescenteCasuale(int[] v)
        //{
        //    v[0] = generaNCasuale(1, 100);
        //    for (int i = 1; i < v.Length; i++)
        //    {
        //        do
        //            v[i] = generaNCasuale(v[i - 1], v[i - 1] + 100);
        //        while (v[i] < v[i - 1]); //accetto valori uguali
        //    }
        //}
        //private static void caricaVettoreOrdinatoCrescenteManuale(int[] v)
        //{
        //    v[0] = inputNumero("Inserisci un valore tra 1 e 100: ", 1, 100);
        //    for (int i = 1; i < v.Length; i++)
        //    {
        //        do
        //            v[i] = inputNumero("Inserisci un valore tra 1 e 100: ", 1, 100);
        //        while (v[i] < v[i - 1]);
        //    }
        //}
        private static void visualizzaMenu()
        {
            Console.Clear();
            Console.WriteLine(" Paolo gay"); //PA
            Console.WriteLine();
            Console.WriteLine("1. Ricerca nomi");
            Console.WriteLine("2. Ricerca nomi a caso con ripetitions");
            Console.WriteLine("2. Ricerca nomi a caso con ripetitions");
            Console.WriteLine("     0 - ESCI");
        }
        private static int inputNumero(string msg, int min, int max) //PF
        {
            bool errore = false;  // Var. LOCALE
            int n = 0;            // Var. LOCALE

            // Input di n
            do
            {
                errore = false;
                Console.WriteLine();
                Console.Write($"{msg} ({min}..{max}) ==> ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valore non valido");
                    errore = true;
                }
            }
            while (errore || n < min || n > max);

            return n;
        }
        private static int generaNCasuale(int min, int max) //PF
        {
            return rnd.Next(min, max);
        }
        private static void caricaVettoreCasuale(int[] v, int min, int max) //PF
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = generaNCasuale(min, max); //PA
        }
        private static void stampaVettore(int[] v) //PF
        {
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine($"--> {i}: {v[i]}");
        }
    }
}