using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
            bool sceltaValida;
            do
            {
                ScriviMenu();
                do
                {
                    sceltaValida = true;
                    Console.Write("\nInserisci la scelta: ");
                    scelta = Console.ReadKey().KeyChar;
                    switch (scelta)
                    {
                        case '1':
                            MediaNumeri();
                            AttesaTasto();
                            break;
                        case '2':
                            MaxNumeri();
                            AttesaTasto();
                            break;
                        case '3':
                            Fattoriale();
                            AttesaTasto();
                            break;
                        case '4':
                            Piramide();
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
                            NumeriPerfetti10000();
                            AttesaTasto();
                            break;
                        case 'q':
                        case 'Q':
                            break;
                        default:
                            //entra qui se non è stata inserita nessuan dei case precedenti
                            sceltaValida = false;
                            break;
                    }
                } while (!sceltaValida);

            } while (scelta.ToString().ToLower() != "q");

        }

        static void ScriviMenu()
        {
            Console.Clear();
            Console.WriteLine("*** MENU CONSOLE ***");
            Console.WriteLine("1. Media Numeri");
            Console.WriteLine("2. Max NUmeri");
            Console.WriteLine("3. Fattoriale ");
            Console.WriteLine("4. Piramide");
            Console.WriteLine("5. Fattori di n");
            Console.WriteLine("6. Numeri Perfetti");
            Console.WriteLine("7. Numeri Perfetti da 1 a 10000");
            Console.WriteLine("Q. USCITA");
        }
        static void MediaNumeri()
        {
            int n, somma;
            double media;
            Random rand = new Random();
            Console.WriteLine("\nMedia di n numeri casuali");
            n = InserisciInteroPositivo();
            somma = 0;
            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 101); // genera tra 1 e 100
                Console.Write(x + " ");
                somma += x;
            }
            Console.WriteLine($"\nla somma è {somma}");
            media = (double)somma / n;// cast a double per fare una divisione reale
            Console.WriteLine($"La media è {media}");
        }
        static void MaxNumeri()
        {
            int n, max;
            Random rand = new Random();
            Console.WriteLine("\nMassimo di n valori");
            n = InserisciInteroPositivo();
            max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(1, 101); // genera tra 1 e 100
                Console.Write(x + " ");
                if (x > max) max = x;
            }
            Console.WriteLine($"\nIl valore massimo è {max}");
        }
        static void Fattoriale()
        {
            int n;
            n = InserisciIntero("Inserisci il numero da fattorializzare ");
            int f;
            f = 1;
            Console.Write($"{n}! = ");
            for (int i = 1; i <= n; i++)
            {
                f = f * i;

                if (i < 2)
                {
                    Console.Write($"{i}");
                }
                else
                {
                    Console.Write($"*{i}");
                }

            }
            Console.WriteLine($" = {f}");
            n = n + 1;

        }
        static void Piramide()
        {
            int n, f, j = 0;

            f = 1;
            n = InserisciIntero("Inserisci il numero di numeri da fattorializzare che formano la base piramide ");
            for (j = 0; j <= 15; j++)
            {
                f = 1;
                Console.Write($"{n}! = ");
                for (int i = 1; i >= n; i++)
                {
                    f = f * i;

                    if (i < 2)
                    {
                        Console.Write($"{i}");
                    }
                    else
                    {
                        Console.Write($"*{i}");
                    }

                }
                Console.WriteLine($" = {f}");
                n = n + 1;

            }
        }
        static void Fattori()
        {
            int n;
            n = InserisciIntero("insierci un numero di cui vuoi sapere i fattori ");
             for (int i = n/2; i > 0 ; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }

        }
        static void NumeriPerfetti()
        {
            int n;
            int perf=0;
            n = InserisciIntero("Inserisci un numero per sapere se è perfetto ");
            for(int i = 1; i <= n/2; i++)
            {
                perf = perf + i;
            }
            if(perf == n)
            {
                Console.WriteLine($"il numero {n} è un numero perfetto!");
            }
            else
            {
                Console.WriteLine($"il numero {n} non è un numero perfetto");
            }
        }
        static void NumeriPerfetti10000()
        {
            int n;
            int s = 1;
            Console.WriteLine("\nI numeri perfetti da 1 a 10000 sono: ");

                for (n = 6; n <= 10000; n++)
                {
                    s = 1;
                    for (int i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0)
                        {
                            s = s + i;
                        }
                    }
                    if (s == n)
                    {
                        Console.WriteLine($"il numero {n} è un numero perfetto!");
                    }
                }
            }
        }
        static int InserisciIntero(string messaggio)
        {
            int n;
            do
            {
                Console.Write("\n"+messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            return n;
        }
        static void AttesaTasto()
        {
            Console.WriteLine("(premi un tasto per continuare)");
            Console.ReadKey();
        }
        static int InserisciInteroPositivo()
        {
            int n;
            do
            {
                Console.Write("\nQuanti numeri vuoi generare? (> 0): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }

    }
}
