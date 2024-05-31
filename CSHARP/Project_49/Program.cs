using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_49
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que cria 2 arrays de 5 posições pares e impares
            // prenche os respectivos arrays com números aleatórios entre 1 e 100

            int[] pares = new int[5];
            int[] impares = new int[5];
            int i = 0;
            int j = 0;
            int random;

            Random aleatorio = new Random();

            while (i < 5 || j < 5)
            {
                random = aleatorio.Next(1, 101);

                if (random % 2 == 0 && i < 5)
                {
                    pares[i] = random;
                    i++;
                }
                else if (random % 2 != 0 && j < 5)
                {
                    impares[j] = random;
                    j++;
                }
            }

            Console.WriteLine("------ Pares -------");
            foreach(int numero_Par in pares)
            {
                Console.WriteLine($"{numero_Par} ");
            }

            
            Console.WriteLine("------ Impares -------");
            foreach(int numero_Impar in impares)
            {
                Console.WriteLine($"{numero_Impar} ");
            }
        }
    }
}