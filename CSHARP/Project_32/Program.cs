using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_32
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que gera 20 números aleatórios entre 1 e 250
            // No final apresenta o maior o menor a soma e média

            int num_Gerado, maior = 1, menor = 250, total = 0;

            Random aleatorio = new Random();

            Console.WriteLine("Números gerados.");

            for (int i = 0;  i < 20; i++)
            {
                num_Gerado = aleatorio.Next(1, 251);
                Console.Write($"{num_Gerado} ");
                total = total + num_Gerado;

                if(num_Gerado > maior)
                {
                    maior = num_Gerado;
                }
                if(num_Gerado < menor)
                {
                    menor = num_Gerado;
                }
            }

            Console.WriteLine($"\n\nO total de número gerados é: {total}");
            Console.WriteLine($"A média de todos os números é: {total/20}");
            Console.WriteLine($"O número maior é: {maior}");
            Console.WriteLine($"O número menor é: {menor}");
        }   
    }
}
