using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_26
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que imprime letra a letra de uma frase e muda de cor de acordo com 
            // posição do i. Se o i for par muda para azul senão mda para amarelo.

            string frase;
            Console.WriteLine("Escreva uma frase!");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write(frase.Substring(i, 1));
                System.Threading.Thread.Sleep(500);
            }
        }  
    }
}