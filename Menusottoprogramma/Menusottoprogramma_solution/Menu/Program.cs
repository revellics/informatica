using System;
using System.Collections.Generic;
using System.Linq;
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
                            MediaNumeri();
                            AttesaTasto();

                            break;
                        case '2':
                            ValoreMax();
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
                            FibonacciSingolo();
                            AttesaTasto();
                            break;
                        case 'd':
                        case 'D':
                            TerneTriangolari();
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
            Console.WriteLine("Q. uscita");
        }
        static void AttesaTasto()
        {
            Console.WriteLine("\npremi un tasto per continuare...");
            Console.ReadKey();
        }
        static int InserisciInteroPositivo(string messaggio)
        {
            int n;
            do
            {
                Console.Write("\n"+messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }  //n<0
        static void MediaNumeri()
        {
            double m;
            int som, n;
            Random rand = new Random();
            Console.WriteLine("\n MEDIA DI N NUMERI CASUALI ");
            n = InserisciInteroPositivo("Inserire numero di numeri");
            som = 0;
            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 101); //101 perchè fa fino al numero precedente quindi 100
                Console.Write(x + " ");
                som += x;
            }
            m = (double)som / n; // cast a double per divisione reale (forzare)
            Console.WriteLine($"\nLa somme è {som} ");
            Console.WriteLine($"La media è {m}");
        }
        static void ValoreMax()
        {
            int n, mx;
            Random rand = new Random();
            Console.WriteLine("\n***MASSIMO DI N VALORI***");
            n = InserisciInteroPositivo("Inserire numero di numeri");
            mx = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 101); //101 perchè fa fino al numero precedente quindi 100
                Console.Write(x + " ");
                if (x > mx)
                    mx = x;
            }
            Console.WriteLine($"\nil masssimo  è {mx}");
        }
        static void Fattoriale()
        {
            int n, f;
            n = InserisciIntero("Inseriscin numero intero(n >= 0): ");
            f = 1;

            Console.Write($"{n}! = ");
            for (int i = 1; i < n; i++)
            {
                f = f * i;
                    Console.Write($"{i}*");
            }
            Console.Write($"{n}");
            f = f * n;
            Console.WriteLine($" = {f}");

        }
        static int InserisciIntero(string messaggio)
        {
            int n;
            do
            {
                Console.Write("\n" + messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            return n;
        }          //n<=0

        static void FattorialePiramide()
        {

            int j, n, f;
            n = InserisciIntero("Inserire il valore massimo ");
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
            n = InserisciInteroPositivo("Inserire Numero da cui ricavare i fattori ");
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
            int n, s=1;
            n = InserisciInteroPositivo("Inserire Numero da verificare sia perfetto ");
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    s=s+i;
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
            n = InserisciInteroPositivo("Inserire Numero da verifica se è primo: ");
            if (n % 2==1)
            {
                c = 3;
                while(n%c!=0 && c<n/2)
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
            for (int k = 2; k <= 1000; k+=2)
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
            int n;
            n = InserisciInteroPositivo("inserire il numero di valori della sequenza di fibonacci da visualizzare: ");
            int c = 0, f = 1, b = 0 ;
            Console.Write($"i numeri della sequenza di fibonacci sono: 0");
            for (; n > 0; n--)
            {
                f = f + b;
                b = c;
                c = f;
                Console.Write($" {f}");
            }
        }
        static void FibonacciSingolo()
        {
            int n;
            n = InserisciInteroPositivo("inserire la posizione del numero nella sequenza di fibonacci: ");
            int c = 0, f = 1, b = 0;
            if (n == 1)
                Console.WriteLine(0);
            for (; n > 1; n--)
            {
                f = f + b;
                b = c;
                c = f;
            }
            Console.Write($"{f}");
        }
        static void TerneTriangolari()
        {
            int n;
            n = InserisciIntero("Inserire il numero di terne: ");
            int c = 1;
            for(int k=1; k<=n; k++)
            {
                Console.Write($"{c}   {k+1}   ");
                c = c + k + 1;
                Console.WriteLine($"{c}");
            }
        }
    }
}
