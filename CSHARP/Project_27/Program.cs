using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_27
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que muda a cor das vogais numa frase

            string frase = "";

            Console.Write("Escreva uma frase: ");
            frase = Console.ReadLine();
            Console.Write("\n");

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase.Substring(i, 1).ToLower() == "a" || frase.Substring(i, 1).ToLower() == "e" || frase.Substring(i, 1).ToLower() == "i" || frase.Substring(i, 1).ToLower() == "o" || frase.Substring(i, 1).ToLower() == "u" || frase.Substring(i, 1).ToLower() == "ã")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(frase.Substring(i, 1));
                Console.ResetColor();
            }
        }
    }
}
