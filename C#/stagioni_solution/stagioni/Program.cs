using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stagioni
{
    internal class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            int g, m;
            string s="";

            Console.Write("inserisci il giorno: ");
            g = Convert.ToInt32(Console.ReadLine());

            Console.Write("inserisci il mese: ");
            m = Convert.ToInt32(Console.ReadLine());

            switch (m)
            {
                case 1:
                case 2:
                    s = "inverno";
                    break;
                case 3:
                    if (g < 21)
                        s = "inverno";
                    else
                        s = "primavera";
                    break;
                case 4:
                case 5:
                    s = "primavera";
                    break;
                case 6:
                    if (g < 21)
                        s = "primavera";
                    else
                        s = "estate";
                    break;
                case 7:
                case 8:
                    s = "estate";
                    break;
                case 9:
                    if (g < 21)
                        s = "estate";
                    else
                        s = "autunno";
                    break;
                case 10:
                case 11:
                    s = "autunno";
                    break;
                case 12:
                    if (g < 21)
                        s = "autunno";
                    else
                        s = "inverno";
                    break;
            }
            Console.WriteLine($"La stagione corrispondente al {g}/{m} è {s}");

            Console.WriteLine();
            Console.WriteLine("premi un tasto per sucire");
            Console.ReadKey();
        }
    }
}
