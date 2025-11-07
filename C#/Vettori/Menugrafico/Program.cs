using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Menugrafico
{
    internal class Program
    {
        static Random r=new Random();
        static void Main(string[] args)
        {
            int n; //lunghezza vettore
            do
            {
                Console.Write("inserisci la lunghezzza del vettore: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            int x;
            do
            {
                Console.Write("inserisci il numero da contare: ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x < 0 || x > 100);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(1, 101);
            } //dichiarzione vettore
            int c=0;
            

            int sp=0, sd=0, mx = int.MinValue;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                s += a[i];
                if (a[i] > mx)
                    mx = a[i];
                if (a[i] == x)
                {
                    c++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (a[i] % 2 == 0)
                    sp += a[i];
                if (a[i] % 2 == 1)
                    sd += a[i];
                Console.WriteLine ($"--> {i}: {a[i]}");
                Console.ResetColor();
            }
            Console.WriteLine($"La media del vettore è: {(s/n).ToString("0.00")}");
            Console.WriteLine($"il valora massimo è: {mx}");
            Console.WriteLine($"il numero {x} è uscito {c} volte");
            Console.WriteLine($"sooma numeri pari: {sp} somma numeri dispari: {sd}s");
            Console.ReadKey();


            /*char scelta;
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
            } while (scelta.ToString().ToLower() != "q" );*/
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
