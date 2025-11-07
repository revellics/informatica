using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlloInutConRipetizione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** CONTROLLO INPUT CON DO ... WHILE ***");
            int n;
            do
            {
                Console.Write("Inserisci un numero intero : ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            Console.WriteLine("hai inserito: " + n);
        }
    }
}
