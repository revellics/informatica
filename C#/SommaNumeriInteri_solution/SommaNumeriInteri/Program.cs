using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommaNumeriInteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Somma numeri interi positivi ***");
            int a=0, b=0;
            int tot = 0;
            string st;
            
            Console.Write("inserire il primo numero inter: ");
            st = Console.ReadLine();
            
            //controllo che sia effettivamente un tipo int
            bool success = int.TryParse(st, out a);  //oltre a restituire vero o false se la conversione va a buon fine mette il dato nella variabile dopo out (a= int.Parse(st))
            if (success && a>0)
            {
                Console.Write("inserire il secondo numero intero positivo: ");
                //b = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out b) && b>0)
                {
                    tot = a + b;
                    Console.WriteLine($"Il totale è: {tot}");
                }
                else
                {
                    Console.WriteLine("il secondo numero deve essere intero e positivo!");
                }
 
            }
            else
            {
                Console.WriteLine("il primo numero deve essere intero e positivo!");
            }




            Console.WriteLine();
            Console.WriteLine("premere un tasto per arrestare");
            Console.ReadKey();
        }
    }
}
