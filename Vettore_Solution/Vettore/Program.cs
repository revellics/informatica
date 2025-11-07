using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Program
    {
        static Random rnd = new Random();
        int j=0;
        static void Main(string[] args, int j)
        {
            int n;
            do
            {
                Console.Write("Inserisci la lunghezza del vettore: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0); // lunghezza vettore
            int[] a = new int[n]; //dichiarisci un vettore
            int x = 0;
            int contx = 0;
            int somp = 0;
            int somd = 0;
            Console.Write("Inserire il valore che si vuole contare: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1, 100);
                if (a[i] == x)
                {
                    contx++;
                }
                if (a[i] % 2 == 0)
                {
                    somp += a[i];
                }else if(a[i] %2 != 0)
                {
                    somd += a[i];
                }
            } // creazione vettore A
            for(int i = 0; i < n; i++)
            {
                if(a[i] == x)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"--> {i}: {a[i]}");
                Console.ForegroundColor = ConsoleColor.White;
            } // stampa vettore A
            double somma = 0;
            for(int i = 0; i < n; i++)
            {
                somma += a[i];
            } // somma valori del vettore A
            Console.WriteLine($"La media del vettore è {(somma / n).ToString("F2")}");
            int max=int.MinValue;
            int min=int.MaxValue;
            for( int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            } // vaolre massimo 
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            } // vaolre minimo
            Console.WriteLine($"Il vaolre massimo è {max}");
            Console.WriteLine($"Il vaolre minimo è {min}");
            Console.WriteLine($"Il vaore inserito è uscito {contx} volte");
            Console.WriteLine($"La somma dei valori pari è {somp}");
            Console.WriteLine($"La somma dei valori dispari è {somd}");
            Console.WriteLine("Vettore B:");
            int[] b = new int[j];
            for (int i = 0;i < n; i++)
            {
                b[j] = a[i];

            } // Copia vettore A
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"--> {i}: {b[i]}");
                Console.ForegroundColor = ConsoleColor.White;
            } // stampa vettore B
        }
    }
}
