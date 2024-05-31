using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_45
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que ordena números dentro de um array do menor para o maior
            // Usando a técnica bubble sort com variavel auxiliar

            int[] numeros = { 10, 40, 20, 8, 35 };
            int[] numeros_Ordenados = new int[5];
            int aux = 0;

            Console.WriteLine("--- Original ----");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros_Ordenados[i] = numeros[i];
                Console.Write($"{numeros[i]} ");
            }

            Console.WriteLine("\n\n---- Números do Array Ordenados ----");
            for(int i = 0; i < numeros_Ordenados.Length - 1; i++)
            {
                for (int j = 0; j < numeros_Ordenados.Length - 1 - i; j++)
                {
                    if(numeros_Ordenados[j] > numeros_Ordenados[j + 1])
                    {
                        aux = numeros_Ordenados[j];
                        numeros_Ordenados[j] = numeros_Ordenados[j + 1];
                        numeros_Ordenados[j + 1] = aux;
                    }
                }
            }
            
            for(int i = 0; i < numeros_Ordenados.Length; i++)
            {
                Console.Write($"{numeros_Ordenados[i]} ");        
            }
        }
    }
}
