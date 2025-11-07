using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Menu
{
    internal class Program
    {
        static Random r = new Random();  //varibile clobale
        static void Main(string[] args)
        {
            char scelta, sceltamenu;
            bool sv, svm;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--> HOME <--");
                Console.ResetColor();
                Console.WriteLine("1. Menù 1 (fino a 10/10/2025)");
                Console.WriteLine("2. Menù 2");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nQ. Esci");
                Console.ResetColor();
                do
                {
                    Console.Write("\ninserisci la scelta: ");
                    sceltamenu = Console.ReadKey().KeyChar;
                    svm = true;
                    switch (sceltamenu)
                    {

                        case '1':
                            do
                            {
                                Console.Clear();
                                ScriviMenu1();

                                do
                                {
                                    sv = true;
                                    Console.Write("\ninserisci la scelta: ");
                                    scelta = Console.ReadKey().KeyChar;
                                    switch (scelta)
                                    {
                                        case '1':
                                            int n = InserisciInteroPositivo("inserire numero di media ");
                                            double m = MediaNumeri(n);
                                            Console.WriteLine($"\nLa media è {m:0.00}");  //versione ridotta di m.ToString("0.00") oppure m.ToString("f2")
                                            AttesaTasto();
                                            break;
                                        case '2':
                                            int mx = ValoreMax();
                                            Console.WriteLine($"\nil masssimo  è {mx}");
                                            AttesaTasto();

                                            break;
                                        case '3':
                                            //Fattoriale(); // richiamo
                                            Console.WriteLine(Fattoriale_funzione());
                                            AttesaTasto();

                                            break;
                                        case '4':

                                            FattorialePiramide();
                                            AttesaTasto();

                                            break;
                                        case '5':
                                            Fattori();
                                            AttesaTasto();
                                            break;
                                        case '6':
                                            NumeriPerfetti();
                                            AttesaTasto();
                                            break;
                                        case '7':
                                            NumeriPerfetti10000(); // basterebbe mostrare 6, 28, 496 e 8128
                                            AttesaTasto();
                                            break;
                                        case '8':
                                            NumeriPrimi();
                                            AttesaTasto();
                                            break;
                                        case '9':
                                            NumeriPrimi1000();
                                            AttesaTasto();
                                            break;
                                        case 'a':
                                        case 'A':
                                            NumeriDeficenti();
                                            AttesaTasto();
                                            break;
                                        case 'b':
                                        case 'B':
                                            Fibonacci();
                                            AttesaTasto();
                                            break;
                                        case 'c':
                                        case 'C':
                                            Console.Write($"{FibonacciSingolo()}");
                                            AttesaTasto();
                                            break;
                                        case 'd':
                                        case 'D':
                                            TerneTriangolari();
                                            AttesaTasto();
                                            break;
                                        case 'e':
                                        case 'E':
                                            Console.WriteLine($"\nSono usciti {Tris()} tris");
                                            AttesaTasto();
                                            break;
                                        case 'f':
                                        case 'F':
                                            Dado();
                                            AttesaTasto();
                                            break;
                                        case 'G':
                                        case 'g':
                                            InserimentoNumeri();
                                            AttesaTasto();
                                            break;
                                        case 'H':
                                        case 'h':
                                            CaparezzaPiramide();
                                            AttesaTasto();
                                            break;
                                        case 'i':
                                        case 'I':
                                            Indovina10();
                                            AttesaTasto();
                                            break;
                                        case 'j':
                                        case 'J':
                                            Tombola();
                                            AttesaTasto();
                                            break;
                                        case 'k':
                                        case 'K':
                                            Indovina100();
                                            AttesaTasto();
                                            break;
                                        case 'l':
                                        case 'L':
                                            Estrazione2Consegutivi();
                                            AttesaTasto();
                                            break;
                                        case 'm':
                                        case 'M':
                                            Sacchetto100();
                                            AttesaTasto();
                                            break;
                                        case 'n':
                                        case 'N':
                                            Inserimento10numeri();
                                            AttesaTasto();
                                            break;
                                        case 'o':
                                        case 'O':
                                            MoltSomme();
                                            AttesaTasto();
                                            break;
                                        case 'p':
                                        case 'P':
                                            GiocoOca();
                                            AttesaTasto();
                                            break;
                                        case 'r':
                                        case 'R':
                                            Dadi2giocatori();
                                            AttesaTasto();
                                            break;
                                        case 's':
                                        case 'S':
                                            Divisione();
                                            AttesaTasto();
                                            break;
                                        case 't':
                                        case 'T':
                                            SommaDadi();
                                            AttesaTasto();
                                            break;
                                        case 'u':
                                        case 'U':
                                            Quadrato2();
                                            AttesaTasto();
                                            break;
                                        case 'v':
                                        case 'V':
                                            Triangolo();
                                            AttesaTasto();
                                            break;
                                        case 'w':
                                        case 'W':
                                            TriangoloInverso();
                                            AttesaTasto();
                                            break;
                                        case 'x':
                                        case 'X':
                                            QuadratoCancelletti();
                                            AttesaTasto();
                                            break;
                                        case 'y':
                                        case 'Y':
                                            UguaglianzaMedie();
                                            AttesaTasto();
                                            break;
                                        case 'z':
                                        case 'Z':
                                            int n1 = InserisciInteroPositivo("inserisci primo fattore");
                                            int n2 = InserisciInteroPositivo("inserisci secondo fattore");
                                            Console.WriteLine(BoiaHoFinitoLoSpazio(n1, n2));
                                            AttesaTasto();
                                            break;
                                        case 'q':
                                        case 'Q':
                                            break;
                                        default: //nessuno dei case precedenti
                                            sv = false;
                                            break;
                                    }
                                } while (!sv);
                            } while (scelta.ToString().ToLower() != "q");
                            break;
                        case '2':
                            do
                            {
                                Console.Clear();
                                ScriviMenu2();
                                do
                                {
                                    Console.Write("\ninserisci la scelta: ");
                                    scelta = Console.ReadKey().KeyChar;
                                    sv = true;
                                    switch (scelta)
                                    {
                                        case '1':

                                            int a = InserisciInteroPositivo();
                                            int b = InserisciInteroPositivo();
                                            Console.WriteLine("prima della trasmissione");
                                            Console.WriteLine($"a:{a} - b:{b}");

                                            Inversione(ref a, ref b);  //se devo averre più di un risultato passo per referenza, cioè la variabile locale corrispondete
                                                                       //modificherà anche quella del parametro attuale
                                            Console.WriteLine("dopo lo scambio");
                                            Console.WriteLine($"a:{a} - b:{b}");
                                            AttesaTasto();
                                            break;

                                        case '2':
                                            int mx = int.MinValue;
                                            int mn = int.MaxValue;
                                            cercaMax(ref mx, ref mn);
                                            Console.WriteLine($"Errore assoluto: {(mx + mn) / 2}");
                                            AttesaTasto();
                                            break;
                                        case '3':
                                            Quadratopieno();
                                            AttesaTasto();
                                            break;
                                        case '4':
                                            QuadratoColoratoRig();
                                            AttesaTasto();
                                            break;
                                        case '5':
                                            QuadratoColoratoSca();
                                            AttesaTasto();
                                            break;
                                        case '6':
                                            X();
                                            AttesaTasto();
                                            break;
                                        case '7':
                                            TriangoloSpec();
                                            AttesaTasto();
                                            break;
                                        case '8':
                                            TriangoloSpecInv();
                                            AttesaTasto();
                                            break;
                                        case '9':
                                            int n = InserisciInteroPositivo("inserire lato finestra", 1, 63);
                                            Console.Clear();
                                            CorniceMonitorColorata(n);
                                            Console.ReadKey(true);
                                            break;
                                        case 'A':
                                        case 'a':
                                            n = InserisciInteroPositivo("inserire lato finestra", 10, Console.LargestWindowHeight);
                                            Console.Clear();
                                            int h = Console.WindowHeight; //salvo le dimenzioni della finestra
                                            b = Console.WindowWidth;
                                            CorniceMonitorCasualLnt(n);
                                            Console.ReadKey(true);
                                            Console.WindowHeight = h;
                                            Console.WindowWidth = b;
                                            break;
                                        case 'B':
                                        case 'b':
                                            n = InserisciInteroPositivo("inserire lato finestra", 10, Console.LargestWindowHeight);
                                            Console.Clear();
                                            h = Console.WindowHeight; //salvo le dimenzioni della finestra
                                            b = Console.WindowWidth;
                                            CorniceMonitorCasualLnt(n, true);
                                            Console.ReadKey(true);
                                            Console.CursorVisible = true;
                                            Console.WindowHeight = h;
                                            Console.WindowWidth = b;
                                            break;
                                        case 'C':
                                        case 'c':
                                            n = InserisciInteroPositivo("inserire lato finestra", 10, Console.LargestWindowHeight);
                                            Console.Clear();
                                            h = Console.WindowHeight; //salvo le dimenzioni della finestra
                                            b = Console.WindowWidth;
                                            CorniceMonitorProgressivo(n, true, true);
                                            Console.ReadKey(true);
                                            Console.CursorVisible = true;
                                            Console.WindowHeight = h;
                                            Console.WindowWidth = b;
                                            break;
                                        case 'q':
                                        case 'Q':
                                            break;
                                        default: //nessuno dei case precedenti
                                            sv = false;
                                            break;
                                    }
                                } while (!sv);

                            } while (scelta.ToString().ToLower() != "q");

                            break;

                    }

                } while (!svm);
            } while (sceltamenu.ToString().ToLower() != "q");


        }



        static void ScriviMenu2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--> MENU 2 <--");
            Console.ResetColor();
            Console.WriteLine("1. inverto due numeri");
            Console.WriteLine("2. cercare max e min");
            Console.WriteLine("3. Quadrato Pieno");
            Console.WriteLine("4. Quadrato Colorato a righe");
            Console.WriteLine("5. Quadrato Colorato a scacchiera");
            Console.WriteLine("6. Quadrato Diagonale");
            Console.WriteLine("7. Triangolo specchiato");
            Console.WriteLine("8. Triangolo specchiato invertito");
            Console.WriteLine("9. Triangolo specchiato invertito");
            Console.WriteLine("A. Cornice monitor");
            Console.WriteLine("B. Cornice monitor Lento");
            Console.WriteLine("c. Cornice monitor Progressiva");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nQ. Ritorna al menù");
            Console.ResetColor();
        }
        static void ScriviMenu1()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--> MENU 1 <--");
            Console.ResetColor();

            Console.WriteLine("1. Media numeri");
            Console.WriteLine("2. Massimo tra numeri");
            Console.WriteLine("3. Fattoriale di n");
            Console.WriteLine("4. Fattoriale dei numeri <= a n");
            Console.WriteLine("5. Fattori di n");
            Console.WriteLine("6. Numero Perfetto");
            Console.WriteLine("7. Numero Perfetti da 1 a 10000");
            Console.WriteLine("8. Numeri primi");
            Console.WriteLine("9. Numeri Primi fino a 1000");
            Console.WriteLine("A. Numeri Deficenti");
            Console.WriteLine("B. Sequenza di fibonacci");
            Console.WriteLine("C. Ennesimo numero della sequenza di fibonacci");
            Console.WriteLine("D. Terne di numeri trinagolari");
            Console.WriteLine("E. Tris tra 3 dadi casuali");
            Console.WriteLine("F. Lancio di due dadi");
            Console.WriteLine("G. Inserimento di valorì finche è negativi sono maggiori");
            Console.WriteLine("H. fibonacci visualizzando le somme");
            Console.WriteLine("I. Indovina il numero tra 1 e 10");
            Console.WriteLine("J. fai ambo in tombola");
            Console.WriteLine("k. Indovina il numero tra 1 e 100");
            Console.WriteLine("L. Estrare numeri casuali da 5 a 10 finchè non ne escono due uguali consegutivi");
            Console.WriteLine("M. Estrare numeri casuali da 1 e 100 finchè il valore non corrisponde al numero di estrazioni");
            Console.WriteLine("N. Inserimento numeri");
            Console.WriteLine("O. Multiplicazioni con somme successive");
            Console.WriteLine("P. Gioco dell'oca");
            Console.WriteLine("R. Gioco 2 giocatori dadi");
            Console.WriteLine("S. Divisioni con sotrazioni successive");
            Console.WriteLine("T. Somma Dadi");
            Console.WriteLine("U. disegna un quadrato");
            Console.WriteLine("V. disegna un traingolo");
            Console.WriteLine("W. disegna un traingolo rovesicato");
            Console.WriteLine("X. disegna un quadrato storto");
            Console.WriteLine("Y. Uguaglianza tra due medie");
            Console.WriteLine("Z. Moltiplicazione");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nQ. Ritorna al menù");
            Console.ResetColor();
        }
        static int Random(int min, int max)  //parametri formali
        {
            return r.Next(min, max + 1);
        }
        static void AttesaTasto()
        {
            Console.WriteLine("\npremi un tasto per continuare...");
            Console.ReadKey();
        }
        /// <summary>
        /// permettte l'input controllato di numeri interi di un range
        /// </summary>   
        /// <param name="messaggio">il messaggio per l'utente</param>
        /// <param name="min">valore minimo ammesso</param>
        /// <param name="max">volere massimo ammesso</param>
        /// <returns>Un numero intero che risponde ai requisiti richiesti</returns>
        static int InserisciInteroPositivo(string messaggio = "introduci un numero intero ", int min = 1, int max = 100) //parametro formale, = serve per mettere dei valori di defoult in caso non vengano specificati
        {
            int n;
            do
            {
                Console.Write("\n" + messaggio);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
            return n;  //return è per indicare la variabile 
        }  //n<0

        private static int BoiaHoFinitoLoSpazio(int n1, int n2)
        {
            int p;
            p = n1 * n2;
            return p;
        }

        private static void UguaglianzaMedie()
        {
            int m = InserisciInteroPositivo("inserire la prima media tra due e dodici: ", 2, 12);
            int n = InserisciInteroPositivo("inserire la seconda media tra due e dodici: ", 2, 12);
            if (MediaNumeri(m) == MediaNumeri(n))
            {
                Console.WriteLine("medie uguali");
            }
            else
            {
                Console.WriteLine("\ndiverse");
            }

        }

        private static string Fattoriale_funzione()
        {
            int n, f;
            n = InserisciInteroPositivo("Inseriscin numero intero(n >= 0): ", 0);
            f = 1;
            string s = "";

            s = s + n + "! = ";
            if (n != 0)
            {
                for (int i = 1; i < n; i++)
                {
                    f = f * i;
                    s = s + i + "*";

                }
                s = s + n;
                f = f * n;
            }
            s = s + " = " + f;

            return s;
        }
        static double MediaNumeri(int n)
        {
            double m;
            int som;
            som = 0;
            for (int i = 0; i < n; i++)
            {
                int x = Random(1, 100); //101 perchè fa fino al numero precedente quindi 100
                Console.Write(x + " ");
                som += x;
            }
            m = (double)som / n; // cast a double per divisione reale (forzare)
            return m;
        }
        static int ValoreMax()
        {
            int n, mx;
            Console.WriteLine("\n***MASSIMO DI N VALORI***");
            n = InserisciInteroPositivo("Inserire numero di numeri tra cui cercare il massimo ");
            mx = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = Random(1, 100); //101 perchè fa fino al numero precedente quindi 100
                Console.Write(x + " ");
                if (x > mx)
                    mx = x;
            }
            return mx;
        }
        static void Fattoriale()
        {
            int n, f;
            n = InserisciInteroPositivo("Inseriscin numero intero(n >= 0): ", 0);
            f = 1;

            Console.Write($"{n}! = ");
            if (n == 0)
            {
                for (int i = 1; i < n; i++)
                {
                    f = f * i;
                    Console.Write($"{i}*");

                }
                Console.Write($"{n}");
                f = f * n;
            }
            Console.WriteLine($" = {f}");


        }

        static void FattorialePiramide()
        {

            int j, n, f;
            n = InserisciInteroPositivo("Inserire il valore massimo ");
            f = 1;

            j = 1;
            for (int k = 0; k <= n; k++)
            {
                f = 1;
                Console.Write($"{j}! = ");
                for (int i = 1; i < j; i++)
                {
                    f = f * i;
                    Console.Write($"{i}*");
                }
                Console.Write($"{j}");
                f = f * j;
                Console.WriteLine($" = {f}");
                j = j + 1;
            }

        }
        static void Fattori()
        {
            int n;
            n = InserisciInteroPositivo("Inserire Numero da cui ricavare i fattori ", 1, int.MaxValue);
            Console.Write($"i fattori di {n} sono : 1");
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    Console.Write($" {i}");
            }
            Console.WriteLine($" {n}");

        }
        static void NumeriPerfetti()
        {
            int n, s = 1;
            n = InserisciInteroPositivo("Inserire Numero da verificare sia perfetto ", 1, int.MaxValue);
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    s = s + i;
            }
            if (s == n)
                Console.WriteLine($"è un numero perfetto");
            else
                Console.WriteLine("non è un numero perfetto");
        }
        static void NumeriPerfetti10000()
        {
            int s;
            int n;
            Console.WriteLine("i numeri perfetti da 1a 1 a 10000 sono:");
            for (n = 6; n <= 10000; n++)
            {
                s = 1;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                        s = s + i;
                }
                if (s == n)
                    Console.Write($" {n}");

            }
        }
        static void NumeriPrimi()
        {
            int n, c = 0;
            n = InserisciInteroPositivo("Inserire Numero da verifica se è primo: ", 1, 1000);
            if (n % 2 == 1)
            {
                c = 3;
                while (n % c != 0 && c < n / 2)
                {
                    c += 2;
                }
                if (n % c == 0)
                    Console.WriteLine("non primo");
                else
                    Console.WriteLine("primo");

            }
            else
                if (n == 2)
            {
                Console.WriteLine($"{n} è un numero primo");
            }

        }
        static void NumeriPrimi1000()
        {
            Console.Write("\nIn numeri pirmi da 1 a 1000 sono: ");
            for (int k = 2; k <= 1000; k += 2)
            {
                int c;
                if (k != 2)
                {
                    c = 3;
                    while (k % c != 0 && c < k / 2)
                    {
                        c += 2;
                    }
                    if (k % c != 0)
                        Console.WriteLine(k);
                }
                else
                {
                    Console.Write($"{k} ");
                    k = k + 1;
                }
            }
        }
        static void NumeriDeficenti()
        {
            int n, s = 1;
            n = InserisciInteroPositivo("Inserire Numero da verificare sia deficente ");
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    s = s + i;
            }
            if (s < n)
                Console.WriteLine($"è un numero deficente");
            else
                Console.WriteLine("non è un numero deficente");
        }
        static void Fibonacci()
        {
            //richiamo di funzione con passaggio PARAMETRI ATTUALI
            int n;
            n = InserisciInteroPositivo("inserire il numero di valori della sequenza di fibonacci da visualizzare: ", 1, 47);
            int c = 0, f = 1, b = 0;
            Console.Write($"i numeri della sequenza di fibonacci sono: 0");
            for (; n > 1; n--)
            {
                f = f + b;
                b = c;
                c = f;
                Console.Write($" {f}");
            }
        }
        static int FibonacciSingolo()
        {
            int n;
            n = InserisciInteroPositivo("inserire la posizione del numero nella sequenza di fibonacci: ", 1, 47);
            int c = 0, f = 1, b = 0;
            if (n == 1)
                Console.WriteLine(0);
            for (; n > 1; n--)
            {
                f = f + b;
                b = c;
                c = f;
            }

            return f;
        }
        static void TerneTriangolari()
        {
            int n;
            n = InserisciInteroPositivo("Inserire il numero di terne: ");
            int c = 1;
            for (int k = 1; k <= n; k++)
            {
                Console.Write($"{c}   {k + 1}   ");
                c = c + k + 1;
                Console.WriteLine($"{c}");
            }
        }
        static int Tris()
        {
            int n = InserisciInteroPositivo("inserire numero di tiri: ");
            int x2, x3, x;
            int t = 0;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {

                x = Random(1, 6);
                x2 = Random(1, 6);
                x3 = Random(1, 6);
                Console.Write($"\n{x}   {x2}   {x3}");
                if (x == x2 && x == x3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\n{x}   {x2}   {x3}");
                    Console.Write(" <-- TRIS");
                    Console.ResetColor();
                    t++;
                }
                Console.Write($"\n{x}   {x2}   {x3}");

            }
            return t;
        }
        static void Dado()
        {
            int d1;
            int d2;
            int c = 0;
            int n = InserisciInteroPositivo("inserire il numero di lanci: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                d1 = Random(1, 6);
                d2 = Random(1, 6);
                if (d1 > d2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{d1} >  {d2}");
                    Console.ResetColor();
                    c++;
                }
                else
                    Console.WriteLine($"{d1} <= {d2}");
            }
            Console.WriteLine($"Il primo dado è maggiore del secondo {c} volte");
        }
        static void InserimentoNumeri()
        {
            int n;
            int cp = 0;
            int cn = 0;
            do
            {
                n = InserisciInteroPositivo("inserire numero: ", int.MinValue, int.MaxValue);
                if (n >= 0)
                    cp++;
                else
                    cn++;
            } while (cp <= cn);
            Console.WriteLine($"I positivi sono: {cp}");
            Console.WriteLine($"I positivi sono: {cn}");
        }
        static void CaparezzaPiramide()
        {
            //richiamo di funzione con passaggio PARAMETRI ATTUALI
            int n;
            int c, f, b;
            n = InserisciInteroPositivo("inserire il numero di valori della sequenza di fibonacci da visualizzare: ", 1, 47);
            Console.Write($"i numeri della sequenza di fibonacci sono:");
            c = 1; f = 0; b = 0;
            for (; n > 1; n--)
            {
                f = c + b;
                Console.Write($"\n{b} + {c} = {f}");
                b = c;
                c = f;
            }

        }
        static void Indovina10()
        {
            const int max_input = 7;
            int n, c, k = 0;
            do
            {
                c = Random(1, 10);
                n = InserisciInteroPositivo("inserisci numero da 1 a 10", 1, 10);
                k++;
                if (c == n)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hai indovinato in {k} volte");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Riprova");
                    Console.ResetColor();
                }
            } while (n != c && max_input != k);
            if (max_input == k)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hai Perso, il numero era {c}");
                Console.ResetColor();
            }

        }
        static void Tombola()
        {
            int n1, c, n2;
            n1 = InserisciInteroPositivo("inserire il primo numero da 1 a 90: ", 1, 90);
            n2 = InserisciInteroPositivo("inserire il secondo numero da 1 a 90: ", 1, 90);
            bool b1 = false, b2 = false;
            do
            {
                c = Random(1, 90);
                Console.Write("\n" + c);
                if (c == n1)
                {
                    Console.Write("<--");
                    b1 = true;
                }
                if (c == n2)
                {
                    Console.Write("<--");

                    b2 = true;
                }

            } while (!b1 || !b2);
            Console.WriteLine("\nAmbo");
        }
        static void Indovina100()
        {

            const int max_input = 7;
            int n, c, k = 0;
            c = Random(1, 100);
            do
            {
                n = InserisciInteroPositivo("Fai nu tentativo da 1 a 100: ");
                k++;
                if (c == n)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hai indovinato in {k} volte");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Riprova");
                    if (c < n)
                    {
                        Console.WriteLine(" troppo grande");
                    }
                    else
                    {
                        Console.WriteLine(" troppo piccolo");
                    }
                    Console.ResetColor();
                }
            } while (n != c && max_input != k);
            if (max_input < k)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hai Perso, il numero era {c}");
                Console.ResetColor();
            }
        }
        static void Estrazione2Consegutivi()
        {
            int c1, c2;
            c1 = 1;
            Console.WriteLine();
            do
            {
                c2 = c1;
                c1 = Random(1, 10);
                Console.WriteLine($"{c1}");
            } while (c2 != c1);
        }
        static void Sacchetto100()
        {
            int c;
            int i = 0;
            do
            {
                c = r.Next(1, 101);
                i++;
                Console.Write($"\n{i}   {c}");
            } while (c != i && i != 100);
        }
        static void Inserimento10numeri()
        {
            int i = 0, n, cn = 0, s = 0;
            do
            {
                n = InserisciInteroPositivo("inserire numero: ", int.MinValue, int.MaxValue);
                i++;
                if (n > 0)
                    s = s + n;
                else
                    cn++;
            } while (i < 10 || n <= 0);
            Console.WriteLine($"la somma dei numeri positivi è: {s}, invece i numeri negativi sono {cn}");
        }
        static void GiocoOca()
        {
            int p1 = 0, p2 = 0;
            int d1, d2;
            bool b = true;
            do
            {
                do
                {
                    d1 = Random(1, 6);
                    d2 = Random(1, 6);
                    if (b)
                    {
                        Console.Write($"\nLancio P1: {d1} {d2}");
                        p1 += d1 + d2;
                    }
                    else
                    {
                        Console.Write($"\nLancio P2: {d1} {d2}");
                        p2 += d1 + d2;
                    }
                } while (d1 == d2);
                b = !b;
            } while (p1 < 100 && p2 < 100);
            if (p1 >= 100)
                Console.WriteLine($"\nP1 ha vinto con {p1} punti");
            else
                Console.WriteLine($"\nP2 ha vinto con {p2} punti");
        }
        static void MoltSomme()
        {
            int a = Random(1, 10);
            int b = Random(1, 10);
            int s = 0;
            for (int i = 0; i < b; i++)
            {
                s += a;
            }
            Console.WriteLine($"\n{a} * {b}= {s}");
        }
        static void Dadi2giocatori()
        {
            int n = InserisciInteroPositivo("inserire numero di round: ", 1);
            int c1 = 0, c2 = 0, d1, d2;
            for (int i = 0; i < n * 2; i++)
            {
                d1 = Random(1, 6);
                d2 = Random(1, 6);
                if (i % 2 == 0)
                {

                    if (d1 == d2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        c1++;
                    }
                    Console.Write($"Giocatore 1: {d1} - {d2} ");
                }
                else
                {
                    if (d1 == d2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        c2++;
                    }
                    Console.WriteLine($"Giocatore 2: {d1} - {d2} ");
                }
                Console.ResetColor();
            }
            if (c1 == c2)
            {
                Console.WriteLine("Pareggio");
            }
            else
            {
                if (c1 > c2)
                {
                    Console.WriteLine("Giocatore 1 ha vinto");
                }
                else
                {
                    Console.WriteLine("Giocatore 2 ha vinto");
                }
            }
        }
        static void Divisione()
        {
            int D = InserisciInteroPositivo("Inserire Dividendo:", 1);
            int d = InserisciInteroPositivo("Inserire Divisore:", 1);
            int c = 0;
            if (D >= d)
            {
                Console.Write($"{D}/{d} = ");
            }
            else
            {
                Console.Write($"{D}/{d}");
            }
            while (D >= d)
            {
                Console.Write($"{D} -{d} = ");
                D = D - d;
                c++;
            }
            if (c >= 1)
            {
                Console.Write(D);
            }
            Console.WriteLine($"\nq = {c} r = {D} ");


        }
        static void SommaDadi()
        {
            int n, d1, d2;
            int c = 0;
            n = InserisciInteroPositivo("inserire il la somma dei due dadi: ", 2, 12);

            do
            {
                d1 = Random(1, 6);
                Console.Write($"dado1: {d1} - ");
                d2 = Random(1, 6);
                Console.WriteLine($"dado2: {d2}");
                c++;
            } while (d1 + d2 != n);
            Console.WriteLine($"Totale lanci = {c}");
        }
        static void Quadrato()
        {
            int n = InserisciInteroPositivo("inserire lunghezza lato ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
            }
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("\n* ");
                for (int k = 0; k < n - 2; k++)
                {
                    Console.Write("  ");
                }
                Console.Write("* ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
            }
        }
        static void QuadratoCancelletti()
        {
            int n = InserisciInteroPositivo("inserire lunghezza lato ");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write("#");
            }
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                    Console.Write("\n#");
                else
                    Console.Write("\n*");
                for (int k = 0; k < n - 2; k++)
                {
                    Console.Write(" ");
                }
                if (i % 2 == 0)
                    Console.Write("#");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write("#");
            }
        }
        static void Triangolo()
        {
            int n = InserisciInteroPositivo("inserire lunghezza base ");
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void TriangoloInverso()
        {
            int n = InserisciInteroPositivo("inserire lunghezza base ");
            for (int i = n; i >= 1; i--)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Inversione(ref int a, ref int b)
        {
            int aus;
            aus = a;
            a = b;
            b = aus;
            Console.WriteLine("Durante la trasmissione X valore");
            Console.WriteLine($"a={a} b={b}");

        }
        static void cercaMax(ref int max, ref int min)
        {
            int x;
            for (int i = 1; 1 <= 10; i++)
            {
                x = Random(1, 100);
                if (x > max)
                    max = x;
                if (min > x)
                    min = x;

            }
        }
        static void Quadratopieno()
        {
            int n = InserisciInteroPositivo();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
        static void QuadratoColoratoRig()
        {
            int n = InserisciInteroPositivo();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Blue;
                for (int k = 0; k < n; k++)
                {
                    Console.Write("+ ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void QuadratoColoratoSca()
        {
            int n = InserisciInteroPositivo();
            bool c = true;
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                    c = !c;
                for (int k = 0; k < n; k++)
                {

                    if (c)
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    else
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("* ");
                    c = !c;
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static void Quadrato2()
        {
            int n = InserisciInteroPositivo("inserire lunghezza lato ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("\n* ");
                if (i != 0 && i != n - 1)
                {
                    for (int k = 0; k < n - 2; k++)
                    {

                        Console.Write("  ");
                    }
                    Console.Write("* ");
                }
                else
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        Console.Write("* ");
                    }
                }

            }

        }
        static void Quadrato2colorato()
        {
            bool c = true;
            int n = InserisciInteroPositivo("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    c = !c;
                }
                for (int j = 0; j < n; j++)
                {
                    if (c)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    c = !c;
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
        static void QuadratoDiagonale()
        {

            int n = InserisciInteroPositivo("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || j == i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
        static void X()
        {

            int n = InserisciInteroPositivo("Inserisci un numero per righe e colonne: ", 2, 500);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i || j == n - i - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor();

        }
        static void TriangoloSpec()
        {
            int n = InserisciInteroPositivo("inserire lunghezza base ");
            for (int i = 0; i <= n; i++)
            {
                /*for(int j = n;  j >= 0; j--)
                {
                    if (j < i)
                        Console.Write("* "):
                    else
                        Console.Write("  ");
                    Console.WriteLine();
                }*/
                Console.Write("".PadLeft((n - i) * 2));
                /*for(int j = n-i-1 ; j >= 0; j--)
                {
                    Console.Write("  ");
                }*/
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void TriangoloSpecInv()
        {
            int n = InserisciInteroPositivo("inserire lunghezza base ");
            for (int i = n; i > 0; i--)
            {
                Console.Write("".PadLeft((n - i) * 2));
                for (int k = 0; k < i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
        private static void CorniceMonitorColorata(int n)
        {

            Console.SetWindowSize(n, n);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
                Console.SetCursorPosition(i, n - 1);
                Console.Write("*");
            }
            for (int i = 1; i < n; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
                Console.SetCursorPosition(n - 1, i);
                Console.Write("*");
            }
        }
        static void CorniceMonitorCasualLnt(int n, bool isDelay = false)
        {
            const int RITARDO = 100;

            ConsoleColor[] colori = {
                ConsoleColor .DarkRed,
                ConsoleColor .DarkGreen,
                ConsoleColor.Magenta,
                ConsoleColor .White,
                ConsoleColor .DarkMagenta
            };
            Random r = new Random();
            Console.SetWindowSize(n, n);
            Console.CursorVisible = false;

            for (int i = 0; i < n; i++)
            {
                if (isDelay) Task.Delay(RITARDO).Wait();
                Console.ForegroundColor = colori[r.Next(colori.Length)];
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
                if (isDelay) Task.Delay(RITARDO).Wait();
                Console.ForegroundColor = colori[r.Next(colori.Length)];
                Console.SetCursorPosition(i, n - 1);
                Console.Write("*");
            }
            for (int i = 1; i < n; i++)
            {
                if (isDelay) Task.Delay(RITARDO).Wait();
                Console.ForegroundColor = colori[r.Next(colori.Length)];
                Console.SetCursorPosition(0, i);
                Console.Write("*");
                if (isDelay) Task.Delay(RITARDO).Wait();
                Console.ForegroundColor = colori[r.Next(colori.Length)];
                Console.SetCursorPosition(n - 1, i);
                Console.Write("*");
            }
            Console.ResetColor();

        }
        private static void CorniceMonitorProgressivo(int n, bool isdelay = false, bool isProgressiva = false)
        {
            const int RITARDO = 100;
            ConsoleColor[] colori =
            {
                ConsoleColor.DarkRed, ConsoleColor.DarkGreen, ConsoleColor.DarkBlue,
                ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow
            };
            Random rand = new Random();
            Console.SetWindowSize(n, n); //finsetra larga n x n
            Console.CursorVisible = false;
            Console.Clear();
            for (int j = 0; j < n; j++)
            {
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(j, 0);
                if (isdelay) Thread.Sleep(RITARDO);
                if (isProgressiva)
                {
                    if (j > 0) Console.SetCursorPosition(j - 1, 0);
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            for (int i = 1; i < n; i++)
            {
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(n - 1, i);
                if (isdelay) Thread.Sleep(RITARDO);
                if (isProgressiva)
                {
                    if (i > n) Console.SetCursorPosition(n - 1, i-1);
                    Console.Write(" ");
                }
                Console.Write("*");
            }
            for (int j = n - 2; j > 0; j--)
            {
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(j, n - 1);
                if (isProgressiva)
                {
                    if (j < n-1) Console.SetCursorPosition(j + 1, n-1);
                    Console.Write(" ");
                }
                if (isdelay)
                {
                    Thread.Sleep(RITARDO);
                }
                Console.Write("*");
            }
            for (int i = n - 2; i > 0; i--)
            {
                Console.ForegroundColor = colori[rand.Next(colori.Length)];
                Console.SetCursorPosition(0, i);
                if (isdelay)
                {
                    Thread.Sleep(RITARDO);
                }
                Console.Write("*");
            }
            Console.ResetColor();
        }
    }
}
