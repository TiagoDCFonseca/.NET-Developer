using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Estrutura de decisão com número aleatório
            Console.ForegroundColor = ConsoleColor.Cyan;
            int num;

            Random aleatorio = new Random();
            num = aleatorio.Next(1,101);

            Console.WriteLine($"O número aleatório é {num}");
            Console.WriteLine("\n");

            if (num > 50)
            {
                Console.WriteLine("O número é maior que 50.");
            }
            else if (num < 50)
            {
                Console.WriteLine("O número é inferior a 50.");
            }
            else
            {
                Console.WriteLine("O número é igual a 50");
            }
        }
    }
}
