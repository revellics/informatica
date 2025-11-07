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
        static int InserisciIntero(string messaggio)
        {
            int n;
            do
            {
                Console.Write("\n"+messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            return n;
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

    }
}
