using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergese2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D,d;
            do
            {
                Console.Write("Inserire Dividendo: ");
            }while(!int.TryParse(Console.ReadLine(), out D) || D<=0);
            do
            {
                Console.Write("Inserire Divisore: ");
            } while (!int.TryParse(Console.ReadLine(), out d) || d <= 0);
            int c = 0;
           
            if (D >= d)
            {
                Console.Write($"{D}/{d} = ");
            }
            else
            {
                Console.Write($"{D}/{d}");
            }
            while (D >= d)
                {
                Console.Write($"{D} -{d} = ");
                D = D - d;
                c++;
                }
            if (c >= 1)
            {
            Console.Write(D);
            }
            Console.WriteLine($"\nq = {c} r = {D} ");
           
            Console.ReadKey();

        }
    }
}
