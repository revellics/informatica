using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es21pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int v;
            int vm=0;
            Console.Write("inserire il numero di numeri: ");
            n= Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < n; i++)
            {
                Console.Write($"inserire il {i + 1}^ numero:");
                v = Convert.ToInt32(Console.ReadLine());
                if (vm < v)
                    vm = v;
            }
            Console.WriteLine($"il numero massimo è: {vm}");
            Console.WriteLine();
            Console.WriteLine("premere un tasto per arrestare il programma");
            Console.ReadKey();
        }
    }
}
