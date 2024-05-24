using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project22
{
    class MainClass
    {  
        public static void Main(string[] args)
        {
            // Jogo de adivinhar o número

            Console.ForegroundColor = ConsoleColor.Blue;
            
            int num_Adivinhar = 0, num_Utilizador = 0, tentativas = 0;
            Random aleatorio = new Random();
            num_Adivinhar = aleatorio.Next(0, 1001);

            Console.Write("Escreva o número que estou a pensar: ");
            num_Utilizador = int.Parse(Console.ReadLine());
            Console.Write("\n");

            while (num_Utilizador != num_Adivinhar)
            {
                if (num_Adivinhar > num_Utilizador)
                {
                    Console.WriteLine("O número é maior!");
                }
                else if (num_Adivinhar < num_Utilizador)
                {
                    Console.WriteLine("O número é menor!");
                }

                tentativas++;
                Console.WriteLine("\n");
                Console.Write("Tenta de novo: ");
                num_Utilizador = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nParabéns acertaste em {tentativas} tentativas.");
        }
    }
}
