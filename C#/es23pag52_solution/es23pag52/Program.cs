using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es23pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("inserire il numero: ");
            }while(!int.TryParse(Console.ReadLine(), out n) || n<1);
            for(int i=2; i<=n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("premere un tasto per arrestare");
            Console.ReadKey();
        }
    }
}
