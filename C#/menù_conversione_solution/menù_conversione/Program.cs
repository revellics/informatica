using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menù_conversione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            int n;
            int r;
            int k;
            string binario = "";
            do
            {
                Console.WriteLine("--> CONVERSIONE TRA BASI <--");
                Console.WriteLine();
                Console.WriteLine("1, DA DEC A BIN");
                Console.WriteLine("2, DA DEC A EXA");
                Console.WriteLine("3, DA BIN A DEC");
                Console.WriteLine("0, ESCI");
                do
                {
                    Console.Write("SCELTA -->");
                    scelta = Convert.ToInt32(Console.ReadLine());
                } while (scelta <0 || scelta >3);
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("da DECIMALE a BINARIO");
                        do
                        {
                            Console.Write("inserisci il numero da convertire");
                            n = Convert.ToInt32(Console.ReadLine());
                        } while (n <= 0);
                        do
                        {
                            r = n % 2;
                            binario =  r.ToString() + binario;
                            n = n / 2;

                        } while (n != 0);
                        Console.WriteLine(binario);
                        break;
                    case 2:
                        Console.WriteLine("da DECIMALE a ESADECIMALE");
                        binario = "";

                        do
                        {
                            Console.Write("inserire numero decimale: ");
                        } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
                        Console.Write("corrisponde in esadeciamle invertito a è: ");
                        do
                        {
                            if (n % 16 < 9)
                            {
                                r = n % 16;
                                binario = r.ToString() + binario;
                            }
                            else
                            {
                                switch (n % 16)
                                {
                                    case 10:
                                        binario = "A" + binario;
                                        break;
                                    case 11:
                                        binario = "B" + binario;
                                        break;
                                    case 12:
                                        binario = "C" + binario;
                                        break;
                                    case 13:
                                        binario = "D" + binario;
                                        break;
                                    case 14:
                                        binario = "E" + binario;
                                        break;
                                    case 15:
                                        binario = "F" + binario;
                                        break;
                                }
                            }
                            n = n / 16;
                        } while (n > 0);
                        Console.WriteLine(binario);
                        break;
                    case 3:
                        Console.WriteLine("da BINARIO a DECIMALE");

                
                        Console.Write("inserire numero di bit ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("inserire numero in binario ");
                        binario = Console.ReadLine();
                        r = 0;
                        k = 0;
                        for (int i = n - 1; i >= 0; i--)
                        {
                            r = r + (int)Math.Pow(2, i) * Convert.ToInt32(binario.Substring(k, 1));
                            k++;

                        }
                        Console.WriteLine(r);
                        break;
                    case 0:
                        Console.WriteLine("Fine programma");
                        break;

                }
                Console.WriteLine("premi un tasto per continuare");
                Console.ReadKey();
                Console.Clear();
            } while (scelta != 0);
            
        }
    }
}
