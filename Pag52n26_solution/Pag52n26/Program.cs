using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag52n26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, f, j = 0;
            /*
             while (n<0);
             f = 1;*/
            
            f = 1;
            n = 0;
            for (j = 0; j <= 15; j++)
            {
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
           
            Console.ReadKey();
        }
    }
}
