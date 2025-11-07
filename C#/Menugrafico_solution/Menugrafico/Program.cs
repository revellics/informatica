using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menugrafico
{
    internal class Program
    {
        static void Main(string[] args)
        {
                char scelta;
            do
            {
                Console.Clear();
                ScriviMenu();
                Console.WriteLine("Inserisci la scelta");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("hai scelto A");
                        Console.ReadKey(true);
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("hai scelto B");
                        Console.ReadKey(true);
                        break;
                    case 'c':
                    case 'C':
                        Console.WriteLine("hai scelto C");
                        Console.ReadKey(true);
                        break;
                    case 'q':
                    case 'Q':
                        break;
                    default:
                        Console.WriteLine("scelta non ammessa");
                        Console.ReadKey(true);
                        break;
                }
            } while (scelta.ToString().ToLower() != "q" );
        }
        static void ScriviMenu()
        {
            Console.WriteLine("*** ESEMPIO MENU***");
            Console.WriteLine("a. ES A");
            Console.WriteLine("b. ES B");
            Console.WriteLine("c. ES C");
            Console.WriteLine("d. ES D");
        }
    }
}
