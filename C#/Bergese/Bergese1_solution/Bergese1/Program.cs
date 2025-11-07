using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergese1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random();
            int n;
            do
            {
                Console.Write("inserire numero di lanci da affettuare per ogni giocatore: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n<=0 );
            int c1=0, c2=0, d1, d2;
            for(int i = 0; i < n*2; i++)
            {
                d1 = r.Next(1,7);
                d2 = r.Next(1, 7);
                if (i % 2 == 0)
                {
                    if (d1 == d2)
                    {
                    Console.ForegroundColor = ConsoleColor.Green;
                        c1++;
                    }
                    Console.Write($"Giocatore 1: {d1} - {d2} ");
                }
                else
                {
                    if (d1 == d2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        c2++;
                    }
                    Console.WriteLine($"Giocatore 2: {d1} - {d2} ");
                }
            Console.ResetColor();
            }
            if (c1 == c2)
            {
                Console.WriteLine("Pareggio");
            }
            else
            {
                if (c1 > c2)
                {
                    Console.WriteLine("Giocatore 1 ha vinto");
                }
                else
                {
                    Console.WriteLine("Giocatore 2 ha vinto");
                }
            }
            Console.ReadKey();
        }
    }
}
