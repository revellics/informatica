using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergese3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r=new Random();
            int n, d1, d2;
            int c = 0;


            do
            {
                Console.Write("inserire il la somma dei due dadi: ");
            }while(!int.TryParse(Console.ReadLine(), out n) || n<2 || n>12);

            do
            {
                d1= r.Next(1,7);
                Console.Write($"dado1: {d1} - ");
                d2 = r.Next(1, 7);
                Console.WriteLine($"dado2: {d2}");
                c++;
            } while (d1+d2!=n);
            Console.WriteLine($"Totale lanci = {c}");
            Console.ReadKey();
        }
    }
}
