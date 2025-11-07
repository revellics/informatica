using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioneinEsadecimale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string exa="";
            int r;


            do
            {
                Console.Write("inserire numero decimale: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n<0);
            Console.Write("corrisponde in esadeciamle invertito a è: ");
            do
            {
                if (n % 16 < 9)
                {
                    r = n % 16;
                    exa = r.ToString() + exa;
                }
                else
                {
                    switch (n % 16)
                    {
                        case 10:
                            exa = "A" + exa;
                            break;
                        case 11:
                            exa = "B" + exa;
                            break;
                        case 12:
                            exa = "C" + exa;
                            break;
                        case 13:
                            exa = "D" + exa;
                            break;
                        case 14:
                            exa = "E" + exa;
                            break;
                        case 15:
                            exa = "F" + exa;
                            break;
                    }
                }
                n = n / 16;
            } while (n > 0);
            Console.WriteLine(exa);
            Console.ReadKey();
        }

    }
}
