using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommaNumeriInteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** SOMMA DI NUMERI INTERI ***");
            int a, b;
            int tot = 0;

            Console.Write("Inserisci il primo numero intero > 0: ");
            string st = Console.ReadLine();
            // a = int.Parse(st);
            bool success =int.TryParse(st, out a);
            if (success && a > 0)
            {
                Console.Write("Inserisci il secondo numero intero > 0: ");
                // b = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out b) && b > 0)
                {

                    tot = a + b;
                    Console.WriteLine($"Il totale è: {tot}");

                }
                else
                {
                    Console.WriteLine("Il secondo numero deve essere intero e > 0!!");
                }

            } else
            {
                Console.WriteLine("Il primo numero deve essere intero e > 0!!");
            }

                Console.ReadKey();
        }
    }
}
