using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es26pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, n, f ;
            do
            {
                Console.Write("inserire numero da fare fattoriare: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<0); //!int.TryParse(Console.ReadLine(), out n)
             f = 1;

            j = 0;
            for (int k = 0; k <= n; k++)
            {
                f = 1;
                Console.Write($"{j}! = ");
                for (int i = 1; i <= j; i++)
                {
                    f = f * i;
                    if (i >=2)
                    {
                        Console.Write($"*{i}");
                    }
                    else
                        Console.Write($"{i}");
                }
                Console.WriteLine($" = {f}");
                j = j + 1;
            }

            Console.ReadKey();

        }
    }
}
