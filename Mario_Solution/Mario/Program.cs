using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int Contpastina = 0;
            int Contpanino = 0;
            double s = 0;
            int gg = 0;
            Console.Write("Inserire la somma di denaro che ha Mario: ");
            s = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Inserisci cosa mangierà oggi Mario\n1. pastina\n2. panino\n");
                n = Convert.ToInt32(Console.ReadLine());
                gg++;
                if (n == 1)
                {
                    Contpastina++;
                    s  = s - 1;
                }
                else if(n == 2)
                {
                    Contpanino++;
                    s = s - 1.5;
                }
            } while(s > 0);
            Console.WriteLine($"Mario ha mangiato {Contpastina} pastine");
            Console.WriteLine($"Mario ha mangiato {Contpanino} panini");
            Console.WriteLine($"Mario ha mangiato per {gg} giorni");
        }
    }
}
