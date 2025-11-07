using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es24pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            do
            {
                do
                {
                    Console.Write("inserire numero minore: ");
                } while (!int.TryParse(Console.ReadLine(), out n1));
                do
                {
                    Console.Write("inserire numero maggiore: ");
                } while (!int.TryParse(Console.ReadLine(), out n2)) ;
            } while (n2<n1);
            for(int i =n1;i<=n2; i++ )
            {
                if (i % 2  == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("premere tasto per arrestare");
            Console.ReadKey();
        }
    }
}
