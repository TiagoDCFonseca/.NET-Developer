using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Verificar se o número é par

            Console.ForegroundColor = ConsoleColor.Cyan;

            int num;
            Random aleatorio = new Random();

            num = aleatorio.Next(1,101);
            Console.WriteLine($"O número escolhido foi {num}");
            Console.WriteLine("\n");

            if (num % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O número é par!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O número é impar");
            }
        }
    }
}
