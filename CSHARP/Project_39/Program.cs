using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_39
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que carrega um array com números aleatórios 

            int[] numeros = new int[10];
            int total = 0;
            Random aleatorio = new Random();

            // Primeiro ciclo carregar o array

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 101);
                Console.Write($"{numeros[i]} ");
                total += numeros[i];
            }

            // Dentro do array vamos verificar e escrever os número Pares e Impares

            Console.WriteLine("\n\n----- PARES -----");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }

            Console.WriteLine("\n\n----- IMPARES -----");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }

            Console.WriteLine("\n\n----- Total de todos os Números -----");
            Console.WriteLine($"Total ---> {total}");
            Console.WriteLine("\n\n----- Média de todos os Números -----");
            Console.WriteLine($"Média ---> {total / numeros.Length}");
        }
    }
}
