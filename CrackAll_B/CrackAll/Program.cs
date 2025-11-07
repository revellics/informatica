using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackAll
{
    internal class Program
    {
        const int MAX = 9;
        const int N_Celle_facile = 3;
        const int N_Celle_medio = 4;
        const int N_Celle_difficile = 5;
        const int N_Tent_facile = 6;
        const int N_Tent_medio = 8;
        const int N_Tent_difficile = 10;
        static int[] codice;
        static int[] tentativi;
        static int cont_tent=0;

        static void Main(string[] args)
        {
            char scelta;
            do
            {
                Console.Clear();
                ScriviMenu();
                Console.WriteLine("Inserisci la scelta");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Creck All - facile");
                        Gioca(N_Celle_facile, N_Tent_facile);
                        Console.ReadKey(true);
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Creck All - medio");
                        Gioca(N_Celle_medio, N_Tent_medio);
                        Console.ReadKey(true);
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("Creck All - difficile");
                        Gioca(N_Celle_difficile, N_Tent_difficile);
                        Console.ReadKey(true);
                        break;
                    case 'q':
                    case 'Q':
                        break;
                    default:
                        Console.WriteLine("scelta non ammessa");
                        Console.ReadKey(true);
                        break;
                }
            } while (scelta.ToString().ToLower() != "q");
        }
        static void ScriviMenu()
        {
            Console.WriteLine("*** Livelli ***");
            Console.WriteLine("a. Livello Facile");
            Console.WriteLine("b. Livello Medio");
            Console.WriteLine("c. Livello Difficile");
            Console.WriteLine("\nq. Quit");
        }
        static void GeneraCodice(int nCelle)
        {
            codice=new int[nCelle];
            Random r= new Random();
            for (int i = 0; i < nCelle; i++)
            {
                codice[i]= r.Next(1, MAX+1);
            }

        }
        static bool Turno(int nCelle)
        {
            tentativi = new int[nCelle];

            for(int i = 0;i < nCelle; i++)
            {
                Console.SetCursorPosition(i*3+1, 6);
                tentativi[i]= InserisciN(1, MAX);
            }
            int cont = 0;

            for (int i = 0; i < nCelle; i++)
            {
                if (tentativi[i] == codice[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    cont++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.SetCursorPosition(i * 3, 4);
                Console.Write(" X ");
            }
            Console.ResetColor();
            return cont == nCelle;
        }
        static void Gioca(int nCelle, int nTentativi)
        {
            Console.Clear();
            GeneraCodice(nCelle);
            cont_tent = 0;

            Console.SetCursorPosition(0, 4);
            Console.ForegroundColor= ConsoleColor.Red;
            for (int i = 0; i < nCelle; i++)
                Console.Write(" X ");
            Console.ResetColor();
            do
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine($"\nTentativi Rimasti: {nTentativi - cont_tent}");
                cont_tent++;
                Console.WriteLine();
            } while (cont_tent <= nTentativi && !Turno(nCelle));

            Console.SetCursorPosition(0, 6);
            if (cont_tent > nTentativi)
            {
                Console.ForegroundColor(ConsoleColor.Red);
                Console.WriteLine("\nHai perso");
                Console.ResetColor();
                Console.Write("La combinazione era: ");
                for (int i = 0; i < nCelle; i++)
                    Console.Write($"{codice[i]} ");
            }
            else
            {
                Console.WriteLine("Hai vinto");
            }
        }
        static int InserisciN( int min = 1, int max = 100) //parametro formale, = serve per mettere dei valori di defoult in caso non vengano specificati
        {
            int n;
            do {} while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;  //return è per indicare la variabile 
        }
    }
}
