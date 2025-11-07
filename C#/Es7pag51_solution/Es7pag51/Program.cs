using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es7pag51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Oi, Of, Od, c=0;

            Console.Write("inserire l'ora iniziale: ");
            Oi= Convert.ToDouble(Console.ReadLine());

            Console.Write("inserire l'ora finale: ");
            Of = Convert.ToDouble(Console.ReadLine());
            if (Oi > 0 && Oi <= 24 && Of > 0 && Of <= 24)
            {
                Od = Of - Oi;
                if (Od < 0)
                    Console.WriteLine("Errore di input");
                else
                {
                    if (Od >= 1)
                    {
                        c = c + 4;
                        if (Od < 5)
                            c = c + (Od - 1) * 3;
                        {
                            c = c + 12;
                            c = c + (Od - 5) * 2;
                        }
                    }
                    Console.WriteLine($"il costo del parcheggio è di euro: {c}");
                }
            }
            else
                Console.WriteLine("errore di input");

            Console.WriteLine();
            Console.WriteLine("premere un tasto per terminare il programma");
            Console.ReadKey();
        }
    }
}
