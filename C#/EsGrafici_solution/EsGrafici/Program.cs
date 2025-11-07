using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsGrafici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Cornice Animata");
            int n;
            do
            {
                Console.Write("inserire lato quadrato: ");
            }while (!int.TryParse(Console.ReadLine(), out n) || n<2 || n>63);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ResetColor();
            ConsoleColor[] color = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.Blue };
            Console.Clear();
            Console.SetWindowSize(n, n);
            Random r= new Random();
            for(int j = 0; j < n-1; j++)
            {

                Console.ForegroundColor = color[r.Next(1, color.Length)];
                Console.SetCursorPosition(j, 0);
                Console.Write("*");
                if (j > 0)
                {
                    Console.SetCursorPosition(j - 1, 0);
                    Console.Write(" ");
                }
                Task.Delay(100).Wait();
                if (j == n - 2)
                {
                    Console.SetCursorPosition(j, 0);
                    Console.Write(" "); 
                }
            }
            for(int i=0; i<=n-1; i++)
            {
                Console.ForegroundColor = color[r.Next(1, color.Length)];
                Console.SetCursorPosition(n-1, i);
                Console.Write("*");
                if (i > 0) 
                {
                    Console.SetCursorPosition(n - 1, i - 1);
                    Console.Write(" ");
                }
                Task.Delay(100).Wait();
                
            }
            for (int j = n-1; j > 0; j--)
            {
                Console.ForegroundColor = color[r.Next(1, color.Length)];
                Console.SetCursorPosition(j, n - 1);
                Console.Write("*");
                Console.SetCursorPosition(j + 1, n - 1);
                Console.Write(" ");
                Task.Delay(100).Wait();
                if (j == 1)
                {
                    Console.SetCursorPosition(j, n - 1);
                    Console.Write(" ");
                }
            }
            for (int i = n-2; i > 0; i--)
            {
                Console.ForegroundColor = color[r.Next(1, color.Length)];
                Console.SetCursorPosition(0 , i);
                Console.Write("*");
                Console.SetCursorPosition(0, i +1);
                Console.Write(" ");
                Task.Delay(100).Wait();
                if (i == 1)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write(" ");
                }
            }
            Console.ReadKey(true);
        }
    }
}
