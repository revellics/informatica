using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackAll
{
    internal class Program
    {
        const int max = 9;
        const int N_celle_F = 3;
        const int N_celle_M = 4;
        const int N_celle_D = 5;

        const int N_tent_F = 6;
        const int N_tent_M = 8;
        const int N_tent_D = 10;

        static int[] codice; // array per codice segreto  
        static int[] tentativi; // array per i tentativi dell'utente

        static int contaTents = 0;
        static bool vinto;

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
                        Console.Clear();
                        Console.WriteLine("CrackAll Facile");
                        Gioca(N_celle_F, N_tent_F);
                        Console.ReadKey(true);
                        //Console.WriteLine(vinto ? "\nHai vinto!!" : "\nHai perso!!");
                        break;
                    case 'b':
                    case 'B':
                        Console.Clear();
                        Console.WriteLine("CrackAll Medio");
                        Gioca(N_celle_M, N_tent_M);
                        Console.ReadKey(true);
                        break;
                    case 'c':
                    case 'C':
                        Console.Clear();
                        Console.WriteLine("CrackAll Difficile");
                        Gioca(N_celle_D, N_tent_D);
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

        private static void Gioca(int nCelle,int nTentatvi)
        {

            GeneraCodice(nCelle);
            contaTents = 0;
            vinto = false;
            Console.SetCursorPosition(0, 4);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < nCelle; i++)
                Console.Write(" X ");
            Console.ResetColor();
            do
            {
                Console.SetCursorPosition(0, 2);
                Console.WriteLine($"\nHai ancora {nTentatvi - contaTents} tentativi...");
                contaTents++;
                vinto = Turno(nCelle);
            } while (contaTents < nTentatvi && !vinto);
            if (vinto)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("\nHai vinto!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHai perso!!");
                Console.Write("La combinazione era: ");
                for (int i = 0; i < nCelle; i++)
                    Console.Write($" {codice[i]} ");
            }
            Console.ResetColor();
        }
        private static bool Turno(int nCelle)
        {
            tentativi = new int[nCelle];
            for(int i = 0; i < nCelle; i++)
            {
                Console.SetCursorPosition(i * 4, 6);
                tentativi[i] = InserisciN($"", 1, max);
            }
            int conta = 0;
            for(int i = 0;i < nCelle; i++)
            {
                if (tentativi[i] == codice[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    conta++;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(i * 4, 6);
                Console.Write(" X ");
            }
                Console.WriteLine("");
                Console.ResetColor();
            return conta == nCelle;

        }

        private static void GeneraCodice(int nCelle)
        {
            codice = new int[nCelle];
            Random rnd = new Random();
            for(int i = 0; i < nCelle; i++)
            {
                codice[i] = rnd.Next(1, max + 1);
            }
        }

        static void ScriviMenu()
        {
            Console.WriteLine("*** Livello di Difficoltà ***");
            Console.WriteLine("a. Facile");
            Console.WriteLine("b. Medio");
            Console.WriteLine("c. Difficile");
            Console.WriteLine("\nq. Esci");
        }
        static int InserisciN(string messaggio = "introduci un numero intero ", int min = 1, int max = 100) 
        {
            int n;
            do
            {
                Console.Write(messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;  //return è per indicare la variabile 
        }
    }
}
