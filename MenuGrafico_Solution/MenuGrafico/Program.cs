using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MenuGrafico
{
    internal class Program
    {
        private static void DisegnaMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*** Menù ***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("a. Quadrato");
            Console.WriteLine("b. Quadrato colorato a righe");
            Console.WriteLine("c. Quadrato colorato a colonne");
            Console.WriteLine("d. Quadrato colorato alternato");
            Console.WriteLine("e. Scacchiera colorata");
            Console.WriteLine("f. Quadrato vuoto");
            Console.WriteLine("g. Quadrato vuoto colorato alternato");
            Console.WriteLine("h. Quadrato vuoto con diagonale");
            Console.WriteLine("i. X Factor");
            Console.WriteLine("j. Vettore");
            Console.WriteLine("k. Triangolo");
            Console.WriteLine("l. Cono rovesciato");
            Console.WriteLine("m. Triangolo specchiato");
            Console.WriteLine("n. Triangolo isoscele");
            Console.WriteLine("o. Triangolo specchiato rovesciato");
            Console.WriteLine("p. Cornice monitor colorata");
            Console.WriteLine("r. Cornice monitor colorata casualmente");
            Console.WriteLine("s. Cornice monitor colorata casualmente lenta");
            Console.WriteLine("t. Cornice monitor colorata casualmente lenta progressiva");
            Console.WriteLine("u. Inverti il vettore A");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nq. esci");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nInserisci la scelta");
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            char scelta = ' ';
            do
            {
                DisegnaMenu();
                scelta = Console.ReadKey().KeyChar;
                switch (scelta)
                {
                    case 'a':
                    case 'A':
                        Console.Clear();
                        Console.WriteLine("Quadrato pieno di *");
                        Quadrato();
                        Console.ReadKey(true);
                        break;
                    case 'b':
                    case 'B':
                        Console.Clear();
                        Console.WriteLine("Quadrato pieno cono colori e righe");
                        QuadratoRighe();
                        Console.ReadKey(true);
                        break;
                    case 'c':
                    case 'C':
                        Console.Clear();
                        Console.WriteLine("Quadrato pieno colorato a colonne");
                        QuadratoColonne();
                        Console.ReadKey(true);
                        break;
                    case 'd':
                    case 'D':
                        Console.Clear();
                        Console.WriteLine("Quadrato pieno colorato alternato");
                        QuadratoAlternato();
                        Console.ReadKey(true);
                        break;
                    case 'e':
                    case 'E':
                        Console.Clear();
                        Console.WriteLine("Scacchiera colorata");
                        Scacchiera();
                        Console.ReadKey(true);
                        break;
                    case 'f':
                    case 'F':
                        Console.Clear();
                        Console.WriteLine("Quadrato vuoto");
                        QuadratoVuoto();
                        Console.ReadKey(true);
                        break;
                    case 'g':
                    case 'G':
                        Console.Clear();
                        Console.WriteLine("Quadrato vuoto colorato alternato");
                        QuadratoVcA();
                        Console.ReadKey(true);
                        break;
                    case 'h':
                    case 'H':
                        Console.Clear();
                        Console.WriteLine("Quadrato vuoto con diagonale");
                        CorniceDiagonale();
                        Console.ReadKey(true);
                        break;
                    case 'i':
                    case 'I':
                        Console.Clear();
                        Console.WriteLine("X Factor");
                        X();
                        Console.ReadKey(true);
                        break;
                    case 'j':
                    case 'J':
                        Console.Clear();
                        Console.WriteLine("Vettore");
                        n = InserisciIntero("Inserisci la lungheza del vettore: ", 1, 4000);
                        int[] v = new int[n]; //dichiarisci un vettore
                        int mn= 1;
                        int mx= 100;
                        int min = int.MaxValue;
                        int max = int.MinValue;
                        MaxMin(v, ref max, ref min);
                        CaricaVettoreCasuale(v, mn, mx);
                        Console.WriteLine($"La media è {Media(v).ToString()}");
                        Console.WriteLine($"Il valore massimo in questo vettore è {max.ToString()}");
                        Console.WriteLine($"Il valore minimo in questo vettore è {min.ToString()}");
                        Console.ReadKey(true);
                        break;
                    case 'k':
                    case 'K':
                        Console.Clear();
                        Console.WriteLine("Triangolo");
                        Triangolo();
                        Console.ReadKey(true);
                        break;
                    case 'l':
                    case 'L':
                        Console.Clear();
                        Console.WriteLine("Cono rovesciato");
                        ConoR();
                        Console.ReadKey(true);
                        break;
                    case 'm':
                    case 'M':
                        Console.Clear();
                        Console.WriteLine("Triangolo Specchiato");
                        TriangoloSpecchiato();
                        Console.ReadKey(true);
                        break;
                    case 'n':
                    case 'N':
                        Console.Clear();
                        Console.WriteLine("Triangolo Isoscele");
                        TriangoloIsoscele();
                        Console.ReadKey(true);
                        break;
                    case 'o':
                    case 'O':
                        Console.Clear();
                        Console.WriteLine("Triangolo specchiato rovesciato");
                        TriangoloSpecRov();
                        Console.ReadKey(true);
                        break;
                    case 'p':
                    case 'P':
                        Console.Clear();
                        Console.WriteLine("Cornice monitor colorata");
                        n = InserisciIntero("Inserisci dimensioni monitor: ", 1, 64);
                        CorniceMonitorColorata(n);
                        Console.ReadKey(true);
                        break;
                    case 'r':
                    case 'R':
                        Console.Clear();
                        Console.WriteLine("Cornice monitor colorata casualmente");
                        n = InserisciIntero("Inserisci dimensioni monitor: ", 1, 63);
                        int wH = Console.WindowHeight;
                        int wB = Console.WindowWidth;
                        CorniceMonitorColorataCasuale(n);
                        Console.ReadKey(true);
                        Console.WindowHeight = wH;
                        Console.WindowWidth = wB;
                        break;
                    case 's':
                    case 'S':
                        Console.Clear();
                        Console.WriteLine("Cornice monitor colorata casualmente lenta");
                        n = InserisciIntero("Inserisci dimensioni monitor: ", 1, 63);
                        wH = Console.WindowHeight;
                        wB = Console.WindowWidth;
                        Console.CursorVisible = false;
                        CorniceMonitorColorataCasuale(n, true);
                        Console.ReadKey(true);
                        Console.WindowHeight = wH;
                        Console.WindowWidth = wB;
                        break;
                    case 't':
                    case 'T':
                        Console.Clear();
                        Console.WriteLine("Cornice monitor colorata casualmente lenta");
                        n = InserisciIntero("Inserisci dimensioni monitor: ", 1, 63);
                        wH = Console.WindowHeight;
                        wB = Console.WindowWidth;
                        Console.CursorVisible = false;
                        CorniceMonitorColorataCasuale(n, true);
                        Console.ReadKey(true);
                        Console.WindowHeight = wH;
                        Console.WindowWidth = wB;
                        break;
                    case 'u':
                    case 'U':
                        Console.Clear();
                        Console.WriteLine("Inverti A");
                        int[] a = new int[InserisciIntero()];
                        int[] b = new int[a.Length];
                        InvertiA(a);
                        Console.ReadKey(true);
                        break;
                    case 'q':
                    case 'Q':
                        break;
                    default:
                        Console.WriteLine("Scelta non ammessa");
                        break;
                }
            } while (scelta != 'q' && scelta != 'Q');
        }
        static int InserisciIntero(string messaggio = "Introduci un numero intero > 0: ", int min = 1, int max = 100)
        {
            int n;
            do
            {
                Console.Write("\n" + messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;
        }
        static void Quadrato()
        {
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void QuadratoRighe()
        {
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void QuadratoColonne()
        {
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void QuadratoAlternato()
        {
            bool c = true;
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    c = !c;
                }
                for (int j = 0; j < n; j++)
                {
                    if (c)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        c = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        c = false;
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void Scacchiera()
        {
            bool c = true;
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    c = !c;
                }
                for (int j = 0; j < n; j++)
                {
                    if (c)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        c = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        c = true;
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void QuadratoVuoto()
        {
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void QuadratoVcA()
        {
            bool c = true;
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    c = !c;
                }
                for (int j = 0; j < n; j++)
                {
                    if (c)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        c = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        c = true;
                    }
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void CorniceDiagonale()
        {
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || j == i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void X()
        {
            int n = InserisciIntero("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - i - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void CaricaVettoreCasuale(int[] v, int mn, int mx)
        {

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = Random(mn, mx);
            }
            StampaVettore(v);
        }
        static void StampaVettore(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"--> {i}: {v[i]}");
            }
        }
        static int Random(int mn, int mx)
        {
            return rnd.Next(mn, mx + 1);
        }
        private static double Media(int[] v)
        {
            double somma = 0;
            for(int i = 0; i < v.Length; i++)
            {
                somma += v[i];
            }
            return somma/v.Length;
        }
        private static void MaxMin(int[] v, ref int max, ref int min)
        {
            for(int i =0; i<v.Length; i++)
            {
                if(v[i] < min)
                {
                    min = v[i];
                }
                if(v[i] > max)
                {
                    max = v[i];
                }
            }
        }
        static void Triangolo()
        {
            int n;
            n = InserisciIntero("Inserisci la larghezza della base: ", 3, 300);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        static void ConoR()
        {
            int n;
            n = InserisciIntero("Inserisci la larghezza della base: ", 3, 300);
            Console.WriteLine("");
            for (int i = n; i > 0; i--)
            {
                for( int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        static void TriangoloSpecchiato()
        {
            int n;
            n = InserisciIntero("Inserisci la larghezza della base: ", 3, 300);
            for( int i = 0; i < n; i++)
            {
                for(int j = n-i;  j > 0; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        static void TriangoloIsoscele()
        {
            int n;
            n = InserisciIntero("Inserisci la larghezza della base: ", 3, 300);
            ConsoleColor[] colori =
            {
                ConsoleColor.DarkRed, ConsoleColor.DarkGreen, ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow
            };
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.ForegroundColor = colori[rand.Next(colori.Length)];
                    Console.Write("* ");
                }
                Console.WriteLine("");
                Console.ResetColor();
            }
        }
        static void TriangoloSpecRov()
        {
            int n;
            n = InserisciIntero("Inserisci la larghezza della base: ", 3, 300);
            Console.WriteLine("");
            for (int i = n; i > 0; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        private static void CorniceMonitorColorata(int n)
        {
            Console.SetWindowSize(n, n); //finsetra larga n x n
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            for(int j = 0; j < n; j++)
            {
                Console.SetCursorPosition(j, 0);
                Console.Write("*");
            }
            for(int i = 1; i < n; i++)
            {
                Console.SetCursorPosition(n-1, i);
                Console.Write("*");
            }
            for (int j = n-2; j > 0; j--)
            {
                Console.SetCursorPosition(j, n-1);
                Console.Write("*");
            }
            for (int i = n-2; i > 0; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
            }
        }
        private static void CorniceMonitorColorataCasuale(int n, bool isdelay = false, bool isProgressiva = false)
        {
            const int RITARDO = 100;
            ConsoleColor[] colori =
            {
                ConsoleColor.DarkRed, ConsoleColor.DarkGreen, ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow
            };
            Random rand = new Random();
            Console.SetWindowSize(n, n); //finsetra larga n x n
            Console.CursorVisible = false;
            Console.Clear();
            for (int j = 0; j < n; j++)
            {
                if (isdelay)
                {
                    Thread.Sleep(RITARDO);
                }
                if (isProgressiva)
                {
                    // devo cancellare il carattere precedente
                    if (j > 0)
                    {
                        Console.SetCursorPosition(j - 1, 0);
                        Console.Write(" ");
                    }
                }
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(j, 0);
                Console.Write("*");
            }
            for (int i = 1; i < n; i++)
            {
                if (isdelay)
                {
                    Thread.Sleep(RITARDO);
                }
                if (isProgressiva)
                {
                    // devo cancellare il carattere precedente
                    if (i > 0)
                    {
                        Console.SetCursorPosition(i - 1, 0);
                        Console.Write(" ");
                    }
                }
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(n - 1, i);
                Console.Write("*");
            }
            for (int j = n - 2; j > 0; j--)
            {
                if (isdelay)
                {
                    Thread.Sleep(RITARDO);
                }
                if (isProgressiva)
                {
                    // devo cancellare il carattere precedente
                    if (j < n-1)
                    {
                        Console.SetCursorPosition(j - 1, 0);
                        Console.Write(" ");
                    }
                }
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(j, n - 1);
                Console.Write("*");
            }
            for (int i = n - 2; i > 0; i--)
            {
                if (isdelay)
                {
                    Thread.Sleep(RITARDO);
                }
                if (isProgressiva)
                {
                    // devo cancellare il carattere precedente
                    if (i > 0)
                    {
                        Console.SetCursorPosition(i + 1, 0);
                        Console.Write(" ");
                    }
                }
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(0, i);
                Console.Write("*");
            }
            Console.ResetColor();
        }
        static void InvertireA(int[] a)
        {
            int aus;
            for (int i = 0; i < a.Length / 2; i++)
            {
                aus = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = aus;
            }
        }
}
