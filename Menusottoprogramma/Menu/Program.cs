using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char scelta;
            bool sv;

            Random rand = new Random();
            do
            {
                ScriviMenu();

                do
                {
                    sv = true;
                    Console.Write("\ninserisci la scelta: ");
                    scelta = Console.ReadKey().KeyChar;
                    switch (scelta)
                    {
                        case '1':
                            double m = MediaNumeri();
                            Console.WriteLine($"\nLa media è {m:0.00}");  //versione ridotta di m.ToString("0.00") oppure m.ToString("f2")
                            AttesaTasto();
                            break;
                        case '2':
                            int mx = ValoreMax();
                            Console.WriteLine($"\nil masssimo  è {mx}");
                            AttesaTasto();

                            break;
                        case '3':
                            Fattoriale(); // richiamo
                            AttesaTasto();

                            break;
                        case '4':

                            FattorialePiramide();
                            AttesaTasto();

                            break;
                        case '5':
                            Fattori();
                            AttesaTasto();
                            break;
                        case '6':
                            NumeriPerfetti();
                            AttesaTasto();
                            break;
                        case '7':
                            NumeriPerfetti10000(); // basterebbe mostrare 6, 28, 496 e 8128
                            AttesaTasto();
                            break;
                        case '8':
                            NumeriPrimi();
                            AttesaTasto();
                            break;
                        case '9':
                            NumeriPrimi1000();
                            AttesaTasto();
                            break;
                        case 'a':
                        case 'A':
                            NumeriDeficenti();
                            AttesaTasto();
                            break;
                        case 'b':
                        case 'B':
                            Fibonacci();
                            AttesaTasto();
                            break;
                        case 'c':
                        case 'C':
                            int f = FibonacciSingolo();
                            Console.Write($"{f}");
                            AttesaTasto();
                            break;
                        case 'd':
                        case 'D':
                            TerneTriangolari();
                            AttesaTasto();
                            break;
                        case 'e':
                        case 'E':

                            Console.WriteLine($"\nSono usciti {Tris()} tris");
                            AttesaTasto();
                            break;
                        case 'f':
                        case 'F':
                            Dado();
                            AttesaTasto();
                            break;
                        case 'G':
                        case 'g':
                            InserimentoNumeri();
                            AttesaTasto();
                            break;
                        case 'H':
                        case 'h':
                            FibonacciPiramide();
                            AttesaTasto();
                            break;
                        case 'I':
                        case 'i':
                            IndovinaNumeri();
                            AttesaTasto();
                            break;
                        case 'J':
                        case 'j':
                            IndovinaNumeriAiuti();
                            AttesaTasto();
                            break;
                        case 'q':
                        case 'Q':
                            break;
                        default: //nessuno dei case precedenti
                            sv = false;
                            break;
                    }

                } while (!sv);
            } while (scelta.ToString().ToLower() != "q");
        }
        static void ScriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** MENU CONSOLE***");
            Console.WriteLine("1. Media numeri");
            Console.WriteLine("2. Massimo tra numeri");
            Console.WriteLine("3. Fattoriale di n");
            Console.WriteLine("4. Fattoriale dei numeri <= a n");
            Console.WriteLine("5. Fattori di n");
            Console.WriteLine("6. Numero Perfetto");
            Console.WriteLine("7. Numero Perfetti da 1 a 10000");
            Console.WriteLine("8. Numeri primi");
            Console.WriteLine("9. Numeri Primi fino a 1000");
            Console.WriteLine("A. Numeri Deficenti");
            Console.WriteLine("B. Sequenza di fibonacci");
            Console.WriteLine("C. Ennesimo numero della sequenza di fibonacci");
            Console.WriteLine("D. Terne di numeri trinagolari");
            Console.WriteLine("E. Tris tra 3 dadi casuali");
            Console.WriteLine("F. Lancio di due dadi");
            Console.WriteLine("G. Inserisci di valorì finche non sono più positivi che negativi");
            Console.WriteLine("H. Piramide di Fibonacci");
            Console.WriteLine("I. Indovina numero tra 1 e 10");
            Console.WriteLine("J. Indovina numero tra 1 e 100 con aiuti");


            Console.WriteLine("\nQ. uscita");
        }
        static void AttesaTasto()
        {
            Console.WriteLine("\npremi un tasto per continuare...");
            Console.ReadKey();
        }
        /// <summary>
        /// permettte l'input controllato di numeri interi di un range
        /// </summary>   
        /// <param name="messaggio">il messaggio per l'utente</param>
        /// <param name="min">valore minimo ammesso</param>
        /// <param name="max">volere massimo ammesso</param>
        /// <returns>Un numero intero che risponde ai requisiti richiesti</returns>
        static int InserisciInteroPositivo(string messaggio = "introduci un numero intero ", int min = 1, int max = 100) //parametro formale, = serve per mettere dei valori di defoult in caso non vengano specificati
        {
            int n;
            do
            {
                Console.Write(messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;  //return è per indicare la variabile 
        }  //n<0
        static double MediaNumeri()
        {
            double m;
            int som, n;
            Random rand = new Random();
            Console.WriteLine("\n MEDIA DI N NUMERI CASUALI ");
            n = InserisciInteroPositivo("Inserire numero di valori di cui fare la media ");
            som = 0;
            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 101); //101 perchè fa fino al numero precedente quindi 100
                Console.Write(x + " ");
                som += x;
            }
            m = (double)som / n; // cast a double per divisione reale (forzare)
            return m;
        }
        static int ValoreMax()
        {
            int n, mx;
            Random rand = new Random();
            Console.WriteLine("\n***MASSIMO DI N VALORI***");
            n = InserisciInteroPositivo("Inserire numero di numeri tra cui cercare il massimo ");
            mx = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 101); //101 perchè fa fino al numero precedente quindi 100
                Console.Write(x + " ");
                if (x > mx)
                    mx = x;
            }
            return mx;
        }
        static void Fattoriale()
        {
            int n, f;
            n = InserisciInteroPositivo("Inseriscin numero intero(n >= 0): ", 0);
            f = 1;

            Console.Write($"{n}! = ");
            if (n == 0)
            {
                for (int i = 1; i < n; i++)
                {
                    f = f * i;
                    Console.Write($"{i}*");

                }
                Console.Write($"{n}");
                f = f * n;
            }
            Console.WriteLine($" = {f}");


        }
        static void FattorialePiramide()
        {

            int j, n, f;
            n = InserisciInteroPositivo("Inserire il valore massimo ");
            f = 1;

            j = 1;
            for (int k = 0; k <= n; k++)
            {
                f = 1;
                Console.Write($"{j}! = ");
                for (int i = 1; i < j; i++)
                {
                    f = f * i;
                    Console.Write($"{i}*");
                }
                Console.Write($"{j}");
                f = f * j;
                Console.WriteLine($" = {f}");
                j = j + 1;
            }

        }
        static void Fattori()
        {
            int n;
            n = InserisciInteroPositivo("Inserire Numero da cui ricavare i fattori ", 1, int.MaxValue);
            Console.Write($"i fattori di {n} sono : 1");
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    Console.Write($" {i}");
            }
            Console.WriteLine($" {n}");

        }
        static void NumeriPerfetti()
        {
            int n, s = 1;
            n = InserisciInteroPositivo("Inserire Numero da verificare sia perfetto ", 1, int.MaxValue);
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    s = s + i;
            }
            if (s == n)
                Console.WriteLine($"è un numero perfetto");
            else
                Console.WriteLine("non è un numero perfetto");
        }
        static void NumeriPerfetti10000()
        {
            int s;
            int n;
            Console.WriteLine("\ni numeri perfetti da 1a 1 a 10000 sono:");
            for (n = 6; n <= 10000; n++)
            {
                s = 1;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        s = s + i;
                }
                if (s == n)
                    Console.Write($" {n}");

            }
        }
        static void NumeriPrimi()
        {
            int n, c = 0;
            n = InserisciInteroPositivo("Inserire Numero da verifica se è primo: ", 1, 1000);
            if (n % 2 == 1)
            {
                c = 3;
                while (n % c != 0 && c < n / 2)
                {
                    c += 2;
                }
                if (n % c == 0)
                    Console.WriteLine("non primo");
                else
                    Console.WriteLine("primo");

            }
            else
                if (n == 2)
            {
                Console.WriteLine($"{n} è un numero primo");
            }

        }
        static void NumeriPrimi1000()
        {
            Console.Write("\nIn numeri pirmi da 1 a 1000 sono: ");
            for (int k = 2; k <= 1000; k += 2)
            {
                int c;
                if (k != 2)
                {
                    c = 3;
                    while (k % c != 0 && c < k / 2)
                    {
                        c += 2;
                    }
                    if (k % c != 0)
                        Console.WriteLine(k);
                }
                else
                {
                    Console.Write($"{k} ");
                    k = k + 1;
                }
            }
        }
        static void NumeriDeficenti()
        {
            int n, s = 1;
            n = InserisciInteroPositivo("Inserire Numero da verificare sia deficente ");
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    s = s + i;
            }
            if (s < n)
                Console.WriteLine($"è un numero deficente");
            else
                Console.WriteLine("non è un numero deficente");
        }
        static void Fibonacci()
        {
            // richiamo di funzione con passaggio PARAMETRI ATTUALI
            int n;
            n = InserisciInteroPositivo("\ninserire il numero di valori della sequenza di fibonacci da visualizzare: ");
            int c = 0, f = 1, b = 0;
            Console.Write($"i numeri della sequenza di fibonacci sono: 0");
            for (; n > 1; n--)
            {
                f = f + b;
                b = c;
                c = f;
                Console.Write($" {f}");
            }
        }
        static int FibonacciSingolo()
        {
            int n;
            n = InserisciInteroPositivo("\ninserire la posizione del numero nella sequenza di fibonacci: ");
            int c = 0, f = 1, b = 0;
            if (n == 1)
                Console.WriteLine(0);
            for (; n > 1; n--)
            {
                f = f + b;
                b = c;
                c = f;
            }

            return f;
        }
        static void TerneTriangolari()
        {
            int n;
            n = InserisciInteroPositivo("\nInserire il numero di terne: ");
            int c = 1;
            for (int k = 1; k <= n; k++)
            {
                Console.Write($"{c}   {k + 1}   ");
                c = c + k + 1;
                Console.WriteLine($"{c}");
            }
        }
        static int Tris()
        {
            int n = InserisciInteroPositivo("\ninserire numero di tiri: ");
            int x2, x3, x;
            int t = 0;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {

                x = rand.Next(1, 7);
                x2 = rand.Next(1, 7);
                x3 = rand.Next(1, 7);
                Console.Write($"\n{x}   {x2}   {x3}");
                if (x == x2 && x == x3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n{x}   {x2}   {x3}");
                    Console.Write(" <-- TRIS");
                    Console.ResetColor();
                    t++;
                }
                Console.Write($"\n{x}   {x2}   {x3}");

            }
            return t;
        }
        static void Dado()
        {
            int d1;
            int d2;
            int c = 0;
            Random rand = new Random();
            int n = InserisciInteroPositivo("\ninserire il numero di lanci: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                d1 = rand.Next(1, 7);
                d2 = rand.Next(1, 7);
                if (d1 > d2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{d1} >  {d2}");
                    Console.ResetColor();
                    c++;
                }
                else
                    Console.WriteLine($"{d1} <= {d2}");
            }
            Console.WriteLine($"Il primo dado è maggiore del secondo {c} volte");
        }
        static void InserimentoNumeri()
        {
            int n;
            int cp = 0;
            int cn = 0;
            Console.WriteLine("\n");
            do
            {
                n = InserisciInteroPositivo("\ninserire numero: ", int.MinValue);
                if (n <= 0)
                    cp++;
                else
                    cn++;
            } while (cp >= cn);
            Console.WriteLine($"\nI numeri positivi sono {cn}");
            Console.WriteLine($"\nI numeri negativi sono {cp}");
        }
        static void FibonacciPiramide()
        {
            // richiamo di funzione con passaggio PARAMETRI ATTUALI
            int n;
            n = InserisciInteroPositivo("\ninserire il numero di valori della piramide della sequenza di fibonacci da visualizzare: ");
            int c = 1, f = 1, b = 0;
            Console.Write($"i numeri della sequenza di fibonacci sono: 0");
            for (; n > 1; n--)
            {
                f = c + b;
                Console.Write($"\n {b} + {c} = {f}");
                b = c;
                c = f;
            }
        }
        static void IndovinaNumeri()
        {
            Random rand = new Random();
            int c = 0;
            const int MAX_Output = 7;
            int x = rand.Next(1, 11);
            int n;
            do
            {
                n = InserisciInteroPositivo("\nIndovina un numero casuale tra 1 e 10 ");
                c++;
                x = rand.Next(1, 11);
                if (n == x)
                {
                    Console.WriteLine("\nIndovinato!!");
                }
                else
                {
                    Console.WriteLine($"\nil numero era {x}");
                }
            } while (n != x && c != MAX_Output);
            if(c == MAX_Output)
            {
                Console.WriteLine("\nHai perso");
            }else 
                Console.WriteLine($"\nci hai inpiegato {c} tentativi");
        }
        static void IndovinaNumeriAiuti()
        {
            Random rand = new Random();
            int c = 0;
            const int MAX_Output = 15;
            int x = rand.Next(1, 101);
            int n;
            do
            {
                n = InserisciInteroPositivo("\nIndovina un numero casuale tra 1 e 100 ");
                c++;
                if (n == x)
                {
                    Console.WriteLine("\nIndovinato!!");
                }
                else
                {
                    if( n > x)
                    {
                        Console.WriteLine("Troppo alto");
                        Console.WriteLine($"Sei al {c}° tentativo");
                    }else
                    {
                        Console.WriteLine("Troppo basso");
                        Console.WriteLine($"Sei al {c}° tentativo");
                    }
                }
            } while (n != x && c != MAX_Output);
            if (c == MAX_Output)
            {
                Console.WriteLine("\nHai perso");
            }
            Console.WriteLine($"\nci hai impiegato {c} tentativi");
            Console.WriteLine($"il numero era {x}");
        }
    }
}
