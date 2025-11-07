using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es22pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=0;
            for(int i=0; i<100; i++)
            {
                n = n + 2;
                Console.WriteLine(n);
            }
        Console.WriteLine();
        Console.WriteLine("premere un tasto per arrestare");
        Console.ReadKey();
        }
    }
}
