using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char scelta;
            bool sceltaValida;
            do
            {
            Console.WriteLine(" Menù Console");
                Console.WriteLine("1. Esercizio 1");
                Console.WriteLine("2. Esercizio 2");
                Console.WriteLine("3. Esercizio 3");
                Console.WriteLine("4. Esercizio 4");
                Console.WriteLine("Q. USCITA");

                do
                {
                    sceltaValida = false;
                    Console.Write("\nInserisci la scelta: ");
                    scelta = Console.ReadKey().KeyChar;
                    switch (scelta)
                    {
                        case '1':
                            sceltaValida = true;
                            Console.WriteLine("\nScelto esercizio 1");
                            Console.WriteLine("(premi un tasto per continuare)");
                            Console.ReadKey();
                            break;
                        case '2':
                            sceltaValida = true;
                            Console.WriteLine("\nScelto esercizio 2");
                            Console.WriteLine("(premi un tasto per continuare)");
                            Console.ReadKey();
                            break;
                        case '3':
                            sceltaValida = true;
                            Console.WriteLine("\nScelto esercizio 3");
                            Console.WriteLine("(premi un tasto per continuare)");
                            Console.ReadKey();
                            break;
                        case '4':
                            sceltaValida = true;
                            Console.WriteLine("\nScelto esercizio 4");
                            Console.WriteLine("(premi un tasto per continuare)");
                            Console.ReadKey();
                            break;
                        case 'q':
                        case 'Q':
                            sceltaValida = true;
                            break;
                    }
                } while (!sceltaValida);

            } while (scelta != 'q' && scelta != 'Q');

        }
    }
}
