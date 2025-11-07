using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Menugrafico
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {

            int n;
            int[] a;
            int[] b;
            char scelta;
            do
            {
                Console.Clear();
                ScriviMenu();
                
                scelta = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (scelta)
                {
                    case 'a':
                    case 'A':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        double s= Media(a);
                        Console.WriteLine($"La media delle {s.ToString("0.00")}");
                        Console.ReadKey(true);
                        break;
                    case 'b':
                    case 'B':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        int max = int.MinValue;
                        int min = int.MaxValue;
                        MassimoeMinimo(a, ref max, ref min);
                        Console.WriteLine($"il valore massimo è {max}, il minimo è {min}");
                        Console.ReadKey(true);
                        break;
                    case 'c':
                    case 'C':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        b = new int[n];
                        CopiareVettore(a, b);
                        Console.WriteLine("vettore b ");
                        StampaV(b);
                        Console.ReadKey(true);
                        break;
                    case 'd':
                    case 'D':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        InvertireV(a);
                        Console.WriteLine("vettore invertiro in se stesso");
                        StampaV(a);
                        Console.ReadKey(true);
                        break;
                    case 'e':
                    case 'E':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        b = new int[n];
                        InvertireVconB(a, b);  //gli arrey vengono trasmessi sempre per referenza
                        Console.WriteLine("vettore invertiro in un altro vettore");
                        StampaV(b);
                        Console.ReadKey(true);
                        break;
                    case 'f':
                    case 'F':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[] { 1, 4, 5, 7, 10};
                        StampaV(a);
                        if (Crescente(a))
                            Console.WriteLine("Crescente");
                        else
                            Console.WriteLine("No");

                        Console.ReadKey(true);
                        break;
                    case 'g':
                    case 'G':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        ContaN(a, Random(1, 100));
                        Console.ReadKey(true);
                        break;
                    case 'h':
                    case 'H':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, 1, 100);
                        int sp=0;
                        int sd = 0;
                        StampaV(a);
                        PariDispari(a, ref sp, ref sd);
                        Console.WriteLine($"la somma dei pari {sp} dispra {sd}");

                        Console.ReadKey(true);
                        break;
                    case 'i':
                    case 'I':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n]; //instanzio il vettore
                        CaricaVRan(a, -100, 100);
                        int p=0;
                        int neg = 0;
                        StampaV(a);
                        PosNeg(a, ref neg, ref p);
                        Console.WriteLine($"positivi {p} Negatuvu {neg}");

                        Console.ReadKey(true);
                        break;
                    case 'j':
                    case 'J':
                        a = new int[] {1, 2, 3};
                        b = new int[] {4, 2, 1, 1,};
                        Console.WriteLine("\nPrimo Vettore");
                        StampaV(a);
                        Console.WriteLine("secondo Vettore");
                        StampaV(b);
                        if (Media(a) == Media(b))
                            Console.WriteLine("medie uguali");
                        else
                            Console.WriteLine("medie diversa");
                        break;
                    case 'k':
                    case 'K':
                        a = new int[] { 1, 2, 3 , 2, 1};
                        Console.WriteLine();
                        StampaV(a);
                        Speculare(a);

                        Console.ReadKey(true);
                        break;
                    case 'l':
                    case 'L':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a);
                        StampaV(a);
                       
                        Vparidispari(a);
                        Console.ReadKey(true);
                        break;  
                    case 'm':
                    case 'M':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a);

                        Console.WriteLine("vettore a");
                        StampaV(a);
                        Console.WriteLine("vettore b");
                        PariTesta(a);
                        Console.ReadKey(true);
                        break;
                    case 'n':
                    case 'N':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a);
                        StampaV(a);
                        Console.WriteLine("i maggiori sono: ");
                        Maggiri3(a);
                        Console.ReadKey(true);
                        break;
                    case 'o':
                    case 'O':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a);
                        StampaV(a);
                        Console.WriteLine("ordinata in ordine crescente: ");
                        ordinaCrescente(a);
                        Console.ReadKey(true);
                        break;
                    case 'p':
                    case 'P':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaValoriDiversi(a,1 , 5);
                        StampaV(a);
                        Console.ReadKey(true);
                        break;
                    case 'r':
                    case 'R':
                        string[] nomi = new string[] {"Gallo", "Calvo", "Ingargiola" , "Bergese", "Kitanoski" };
                        int[] punti = new int[nomi.Length]; 
                        CaricaVRan(punti ,1 , 1000);
                        StampaVs(nomi, punti, "stampa vettori");
                        Cerca3maxParalleli(nomi, punti);
                        Console.ReadKey(true);
                        break;
                    case 's':
                    case 'S':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a =new int[n];
                        CaricaVManCrescente(a, "");
                        StampaV(a);
                        Console.ReadKey(true);
                        break;
                    case 't':
                    case 'T':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRanCrescente(a, "");
                        StampaV(a);
                        Console.ReadKey(true);
                        break;
                    case 'u':
                    case 'U':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a, 1, 100);
                        StampaV(a);
                        int x = Random(1, 100);
                        int posix = RicercaSequenzialeX(a, x);
                        if (posix == -1)
                            Console.WriteLine("elemento non trovato");
                        else
                            Console.WriteLine($"elemento {x} trovato in posizione {posix}");
                        Console.ReadKey(true);

                        break;
                    case 'v':
                    case 'V':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRanDisgiunto(a, 1, 1000);
                        StampaV(a);
                        Console.ReadKey(true);
                        break;
                    case 'W':
                    case 'w':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a);
                        StampaV(a);
                        Console.WriteLine("Traslazione di 1: ");
                        TraslareV(a);
                        Console.ReadKey(true);
                        break;
                    case 'x':
                    case 'X':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        CaricaVRan(a);
                        StampaV(a);
                        bool bo = ElementiDistinti(a);
                        if (bo)
                            Console.WriteLine("Gli elementi sono tutti diversi");
                        else
                            Console.WriteLine("Ci sono delle differenze");
                        Console.ReadKey(true);
                        break;
                    case 'y':
                    case 'Y':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        a = new int[n];
                        Fibonacci(a);
                        StampaV(a);
                        Console.ReadKey(true);
                        break;
                    case 'z':
                    case 'Z':
                        n = InserisciN("inserire lunghezza vettore: ", 1, 200);
                        nomi = new string[] {"Allione", "Atanasov", "Azzolina", "Frocio bastardo", "Calvo", "Cannella", "Capatti", "Chiarena", "Cojocaru", "Drago", "Gaidano", "Gallo", "Ingargiola", "Kitanovski", "Manova", "Mayam", "Picco", "Racca", "Revello", "Sona", "Soster", "Taricco", "Tripi", "Voinovski", };
                        TurniInterrogazioni(nomi, n);
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
            } while (scelta.ToString().ToLower() != "q" );
        }


        static void CaricaVRanDisgiunto(int[] a, int v1, int v2)
        {
            int j;
            int x;
            a[0] = Random(v1, v2);
            for (int i=0; i<a.Length; i++)
            {
                do
                {
                    j = 0;
                    x = Random(v1, v2);
                    while (a[j] != x && j < i)
                    {
                        j++;
                    }
                } while (a[j] == x);
                a[i]=x ;
            }
        }
        static void Cerca3maxParalleli(string[] nomi, int[] punti)
        {
            int[] mag = new int[3];
            int[] indice = new int[3] { -1, -1, -1 };

            for (int i = 0; i < punti.Length; i++)
            {
                if (punti[i] > mag[0])
                {
                    mag[1] = mag[0];
                    mag[2] = mag[1];
                    mag[0] = punti[i];
                    indice[1] = indice[0];
                    indice[2] = indice[1];
                    indice[0] = i;
                }
                else
                {
                    if (punti[i] > mag[1])
                    {
                        mag[2] = mag[1];
                        mag[1] = punti[i];
                        indice[2] = indice[1];
                        indice[1] = i;
                    }
                    else
                    {
                        if (punti[i] > mag[2])
                            mag[2] = punti[i];
                            indice[2] = i;
                    }
                }
            }
            Console.WriteLine($"\n1 {nomi[indice[0]]} con {mag[0]}\n2 {nomi[indice[1]]} con {mag[1]}\n3 {nomi[indice[2]]} con {mag[2]}\n");
        }
        static void StampaVs(string[] nomi, int[] punti, string v)
        {
            Console.WriteLine(v);
            for (int i = 0; i < nomi.Length; i++)
            {
                Console.WriteLine($"Nome {nomi[i]} -- Punti  {punti[i]}");
            }
        }
        static void PosNeg(int[] v, ref int n, ref int p)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] <0)
                   n++;
                else
                   p++;
            }
        }

        static void ScriviMenu()
        {
            Console.WriteLine("***Esercizzi Vettori***");
            Console.WriteLine("a. Media Numeri");
            Console.WriteLine("b. Massimo Minimo");
            Console.WriteLine("c. Copiare un vettore");
            Console.WriteLine("d. Invertire un vettore in se stesso");
            Console.WriteLine("e. Invertire un vettore in un altro vettore");
            Console.WriteLine("f. Invertire un vettore in un altro vettore");
            Console.WriteLine("g. Conatare un numero");
            Console.WriteLine("h. somma Pari Disapri");
            Console.WriteLine("i. Conta Pari Disapri");
            Console.WriteLine("j. Controlla media");
            Console.WriteLine("k. controllo speculiarità");
            Console.WriteLine("l. Divide i pari e dispari");
            Console.WriteLine("m. Caparezza priamide");
            Console.WriteLine("n. Patrizio");
            Console.WriteLine("o. Ordina un vettore in maniera crescente");
            Console.WriteLine("p. ");
            Console.WriteLine("r. ");
            Console.WriteLine("s. Ordina il vettore manualmente ");
            Console.WriteLine("t. Ordina il vettore casualmente ");
            Console.WriteLine("u. Ricerca x sequenziale in vettore ");
            Console.WriteLine("v. Genera vettore casualmente senza ripetizioni ");
            Console.WriteLine("w. Traslazione di un vettore circolare");
            Console.WriteLine("x. Verificare che il vettore sia fatto solo da numeri diversi");
            Console.WriteLine("y. Fibonacci in un vettore");


            Console.WriteLine("\nq. Esci");
            Console.Write("Inserisci la scelta: ");
        }
        static int InserisciN(string messaggio = "introduci un numero intero ", int min = 1, int max = 100) //parametro formale, = serve per mettere dei valori di defoult in caso non vengano specificati
        {
            int n;
            do
            {
                Console.Write(messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;  //return è per indicare la variabile 
        }  //n<0
        static void CaricaVRan(int[] v, int mn = 1, int mx = 100)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = Random(mn, mx);
            } //dichiarzione vettore
        }
        static void StampaV(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"--> {i}: {v[i]}");
            }
        }
        static int Random(int mn, int mx)
        {
            int n = r.Next(mn, mx + 1);
            return n;
        }
        static void MassimoeMinimo(int[] v, ref int max, ref int min)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > max)
                    max = v[i];
                if (v[i] < min)
                    min = v[i];
            }
        }
        static double Media(int[] v)
        {
            double s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s += v[i];
            }
            return s/v.Length ;
        }
        static void InvertireV(int [] v)
        {
            int aus;
            for (int i = 0; i < v.Length/2; i++)
            {
                aus = v[i];
                v[i] = v[v.Length - i - 1];
                v[v.Length - i - 1]= aus;
            }
        }
        static void InvertireVconB(int[] v, int[] b)
        {
            for(int i=0; i<v.Length; i++)       //i++ riduce le micro istruzioni, se faccio a[i++] =7                a[++i] = 7
                b[v.Length - i - 1] = v[i];     //            notazione post fissa, incremento dopo che ho inserito    notazione prefissa, aumenta primq
        }
        static void CopiareVettore(int[] v, int[] b)
        {
            for (int i = 0; i < v.Length; i++)
            {
                b[i] = v[i];
            }
        }
        static bool Crescente(int[] v)
        {
            int i=1;
            while (v[i] > v[i - 1] && i != v.Length)
            {
                i++;
            }
            return v[i] > v[i - 1];
        }
        static void ContaN(int[] v, int x)
        {
            int c=0;
            for (int i = 0; i < v.Length; i++)
            {
                if(v[i] == x)
                    c++;
            }
            Console.WriteLine($"il numoero {x} compare {c} volte");
        }
        static void PariDispari(int[] v, ref int sp, ref int sd)
        {
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] % 2 == 0)
                    sp=sp+v[i];
                else
                    sd = sp + v[i];
            }
        }
        static void Speculare(int[] v)
        {
            int i = 0;
            while (i<v.Length/2 && v[i] == v[v.Length-1-i]) // 1, 2, 3, 2, 1
                i++;
            if (v[i] != v[v.Length - 1 - i])
                Console.WriteLine("non speculari");
            else
                Console.WriteLine("speculari");
        }
        static void Vparidispari(int[] v)
        {
            int[] p=new int[v.Length];
            int k = 0;
            int[] d= new int[v.Length];
            int j = 0;

            for(int i=0; i<v.Length; i++)
            {
                if (v[i] % 2 == 0)
                    p[k++] = v[i];
                else
                    d[j++] = v[i];
            }
            Array.Resize(ref p, k);
            Array.Resize(ref d, j); //permette di allungare o accorciare un array
            Console.WriteLine($"I pari sono {k}");
            StampaV(p);
            Console.WriteLine($"I pari sono {j}");
            StampaV(d);
            

        }
        static void PariTesta(int[] v)
        {
            int[]b= new int[v.Length];
            int k = 0;
            int j = b.Length-1;
            for(int i=0; i<v.Length; i++)
            {
                if (v[i] % 2 == 0)
                    b[k++] = v[i];
                else
                    b[j--] = v[i]; 
            }
            StampaV(b);
        }
        static void Maggiri3(int[] v)
        {
            int[] mag = new int[3];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > mag[0])
                {
                    mag[1] = mag[0];
                    mag[2] = mag[1];
                    mag[0] = v[i];
                }
                else
                {
                    if (v[i] > mag[1])
                    {
                    mag[2] = mag[1];
                    mag[1] = v[i];
                    }
                    else
                    {
                        if (v[i] > mag[2])
                            mag[2] = v[i];
                    }
                }
            }
            StampaV(mag);
        }
        static void ordinaCrescente(int[] v)
        {
            int aus;
            int k;
            for(int i = v.Length-2; i >= 0; i--)
            {
                k = i;
                    while (k < v.Length-1 && v[k] > v[k + 1])
                    {
                        aus = v[k];
                        v[k] = v[k + 1];
                        v[k + 1] = aus;
                        k++;
                    }
            }
            StampaV(v);
        }
        static void CaricaValoriDiversi(int[] v, int mn=1, int mx=100)
        {
            bool b;
            int k=0;
            for (int i = 0; i < v.Length; i++)
            {
                do
                {
                    v[i] = Random(mn, mx);
                    k = 0;
                    b = false;
                    while (k < v.Length && b==false )
                    {
                        if (i == k)
                            b = true;
                        else
                        {
                            if (v[i] == v[k])
                            {
                                b = true;
                            }
                            k++;
                        }
                    }
                    if (k >= v.Length || k==i)
                    {
                        b = false;
                    }
                } while (b);
            }
        }
        static void CaricaVManCrescente(int[] v, string s="")
        {
            v[0] = InserisciN($"il 1 numero: ");
            for (int i = 1; i < v.Length; i++)
            {
                do
                {
                    v[i] = InserisciN($"il {i+1} numero: ");
                } while (v[i-1]> v[i]);
            }
        }
        static void CaricaVRanCrescente(int[] v, string s = "")
        {
            v[0] = InserisciN($"il 1 numero: ");
            for (int i = 1; i < v.Length; i++)
            {
                do
                {
                    v[i] = Random(1, 1000);
                } while (v[i - 1] > v[i]);
            }
        }
        static int RicercaSequenzialeX(int[] v, int x)
        {
            int i = 0;
            while (i < v.Length-1 && v[i] != x) 
                i++;
            if (v[i] == x)
                return i;
            else
                return -1;
        }
        static void TraslareV(int[] v)
        {
            int aus;
            for (int i = 0; i <= v.Length - 2; i++)
            {
                    aus = v[i];
                    v[i] = v[i + 1];
                    v[i + 1] = aus;
            }
            StampaV(v);
        }
        static bool ElementiDistinti(int[] v)
        {
            bool b=false;
            int k=0;
            int i =0;
            while(i < v.Length && v[i-1] != v[k]){
                k = i;
                while (k < v.Length-1 && v[i] != v[k])
                {
                    k++;
                }
                if (k == v.Length)
                    k--;
                i++;
            }
            if(v[i - 1] != v[k])
                b=true;

            return b;
        }
        static void Fibonacci(int[] v)
        {
            int a = 0, b = 1, c;
            for(int i = 0; i < v.Length - 1; i++)
            {
                v[i] = a;
                c = a + b;
                a = b;
                b = c;
            }
        }
        static void TurniInterrogazioni(string[] nomi, int n)
        {
            int x;
            int t = nomi.Length / n;
            for( int i = 0; i < t; i++ )
            {
                Console.WriteLine("");
                Console.WriteLine($"Turno {i+1}:");
                for( int j = 1; j <= n; j++)
                {
                    do
                    {
                        x = Random(0, nomi.Length-1);
                    } while (nomi[x] == "");
                    Console.WriteLine($"{nomi[x]}");
                    nomi[x] = "";
                }
            }
            if(nomi.Length % n != 0)
            {
                for( int i = 0; i < nomi.Length; i++)
                {
                    if( nomi[i] == "")
                    {
                        Console.WriteLine($"{nomi[i]}");
                    }
                }
            }
        }
    }   
}
