using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_conversioni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            int n;
            string r;
            string binario = "";
            string exa;
            do
            {
                Console.WriteLine("--> CONVERSIONI TRA BASI <--");
                Console.WriteLine();
                Console.WriteLine("1. Da DEC a BIN");
                Console.WriteLine("2. Da DEC a EXA");
                Console.WriteLine("3. Da BIN a DEC");
                Console.WriteLine("   0. ESCI");
                do
                {
                    Console.Write("SCELTA --> ");
                    scelta = Convert.ToInt32(Console.ReadLine());
                } 
                while (scelta < 0 || scelta > 3);
                
                switch(scelta)
                {
                    case 1:
                        Console.WriteLine("Da DECIMALE a BINARIO");
                        do
                        {
                            Console.Write("Inserisci il numero da convertire --> ");
                            n = Convert.ToInt32(Console.ReadLine());
                        } 
                        while (n<=0);
                        do
                        {
                            r = n % 2;
                            binario = r.ToString() + binario;
                            n = n / 2;
                        } 
                        while (n!=0);
                        Console.WriteLine(binario);
                        break;
                    case 2:
                        Console.WriteLine("Da DECIMALE a ESADECIMALE");
                        do
                        {
                            Console.Write("Inserisci il numero da convertire --> ");
                            n = Convert.ToInt32(Console.ReadLine());
                        }
                        while (n <= 0);
                        do
                        {
                            r.ToString() = n % 16;
                            if(r >= 10)
                            {
                                if(r == 10)
                                {
                                    r = "A";
                                }else if(r == 11)
                                {
                                    r = "B";
                                }else if (r == 12)
                                {
                                    r = "C";
                                }else if(r == 13)
                                {
                                    r = "D";
                                }else if(r == 14)
                                {
                                    r = "E";
                                }else
                                {
                                    r = "F";
                                }
                            }
                            exa = r + exa;
                            n = n / 16;
                        }
                        while (n != 0);
                        Console.WriteLine(exa);
                        break;
                    case 3:
                        Console.WriteLine("Da BINARIO a DECIMALE");
                        break;
                    case 0:
                        Console.WriteLine("Fine programma");
                        break;
                }
                Console.WriteLine("Premi un tasto per continuare...");
                Console.ReadKey();
                Console.Clear();
            }
            while (scelta != 0);
        }
    }
}
