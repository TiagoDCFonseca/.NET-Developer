using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_42
{
    class MainClass
    {
        public static void Main(string[] args)
        {
             /*
             Gerar 10 números aleatórios entre 1 e 1000 e efetuar o seguinte:
             • Apresentar tods os números no ecran 
             • Apresentar só os pares 
             • Mostrar qual o valor menor, o maior e a média 
             • Mostrar os que são primos 
             */

             int[] num_Gerado = new int[10];
             int maior = 1, menor = 1000, total = 0, primos = 0;
             Random aleatorio = new Random();

             for (int i = 0; i < num_Gerado.Length; i++)
             {
                num_Gerado[i] = aleatorio.Next(1, 1001);
                Console.Write($"{num_Gerado[i]} ");
                System.Threading.Thread.Sleep(400);

                total += num_Gerado[i];

                if (num_Gerado[i] > maior)
                {
                    maior = num_Gerado[i];
                }
                if (num_Gerado[i] < menor)
                {
                    menor = num_Gerado[i];
                }
                if (VerificaPrimo(num_Gerado[i]))
                {
                    primos = num_Gerado[i];
                }
             }

            Console.WriteLine("\n\n----- Escreve os números pares -----");
            for (int i = 0; i < num_Gerado.Length; i++)
            {
                if(num_Gerado[i] % 2 == 0)
                {
                    Console.Write($"{num_Gerado[i]} ");
                    System.Threading.Thread.Sleep(400);
                }
            }

            Console.WriteLine("\n\n----- Maior e Menor -----");
            Console.WriteLine($"O maior número foi {maior} e o menor número foi {menor}.");

            Console.WriteLine("\n\n----- Os Números Primos -----");
            if(primos != 0)
            {
                Console.WriteLine($"{primos} ");
            }
            else
            {
                Console.WriteLine("Número Primo não Encontrado");
            }

        }

        static bool VerificaPrimo(int numero)
        {
            int divisores = 0;
            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores++;
                }
            }
            if(divisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
