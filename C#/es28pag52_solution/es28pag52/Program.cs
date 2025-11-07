using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es28pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string m;
            Console.Write("inserire numero di bit ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("inserire numero in binario ");
            string v = Console.ReadLine();
            int b=0;
            int k = 0;
            for (int i=n-1; i >=0 ; i--)
            {
                b = b + (int)Math.Pow(2, i) * Convert.ToInt32(v.Substring(k, 1));
                k++;
             
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
