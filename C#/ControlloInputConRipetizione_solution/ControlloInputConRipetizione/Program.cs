using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlloInputConRipetizione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** CONTROLLO INPUT CON DO...WHILE");
            int n=0;  //dichiaro le variabili fuori dal ciclio perchè altrimenti non è considerato fuori da esso
            
            do
            {
                Console.Write("inserisci un numero intero: ");
            } while (!int.TryParse(Console.ReadLine(), out n ) || n<=0);

            Console.WriteLine("hai inserito: " + n);

            Console.WriteLine();
            Console.WriteLine("premere un tasto per arrestare");
            Console.ReadKey();
        }
    }
}
