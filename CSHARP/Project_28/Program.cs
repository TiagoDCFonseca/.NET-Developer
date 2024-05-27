using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Project_28
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que escreve uma frase do final para o inicio
            
            string frase, frase_Original;

            Console.Write("Escreva uma frase: ");
            frase_Original = Console.ReadLine();

            for (int i = frase_Original.Length - 1; i >= 0; i--)
            {
                frase = frase_Original;
                Console.Write(frase.Substring(i, 1));
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}