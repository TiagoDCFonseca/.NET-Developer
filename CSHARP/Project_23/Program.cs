using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project23
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Programa que pergunta ao utilizador quantos números
            pretende gerar entre um mínimo e máximo definido pelo mesmo.
            Troca de cor se o número é par ou impar. Determina qual o maior
            valor gerado e o menor, e também a soma de todos os números.
            */

            int numeros = 0, min = 0, max = 0, num_Gerado = 0, total = 0;
            int maior = 0, menor = 0;

            Console.Write("Quantos números pretendes gerar: ");
            numeros = int.Parse(Console.ReadLine());
            Console.Write("\nQual o valor mínimo: ");
            min = int.Parse(Console.ReadLine());
            maior = min;
            Console.Write("\nQual o valor máximo: ");
            max = int.Parse(Console.ReadLine());
            menor = max;
            Console.Write("\n");

            Random aletorio = new Random();
            
            for (int i = 0; i < numeros; i++)
            {
                num_Gerado = aletorio.Next(min, max + 1);

                if (num_Gerado % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{num_Gerado} ");
                System.Threading.Thread.Sleep(400);

                if (num_Gerado > maior)
                {
                    maior = num_Gerado;
                }
                else if (num_Gerado < menor)
                {
                    menor = num_Gerado;
                }

                total = total + num_Gerado;
            }
            Console.ResetColor();
            Console.WriteLine($"\n\nO maior número gerado foi: {maior}");
            Console.WriteLine($"O menor número gerado foi: {menor}");
            Console.WriteLine($"A soma dos números foi: {total}\n");
        }
    }
}
