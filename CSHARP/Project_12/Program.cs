using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa para determinar o tipo de triângulo
            // recebendo os valores do utilizador

            int lado1, lado2, lado3;

            Console.WriteLine("Insira o valor do lado 1.");
            lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado 2.");
            lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do lado 3.");
            lado3 = int.Parse(Console.ReadLine());

            //Testa se os lados são todos iguais
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O triângulo é equilátero");
            }
            // Testa se os lados são diferentes uns dos outros
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("O triângulo é escaleno");
            } 
            else
            {
                // Se as condições acimas forem falsas executa bloco abaixo
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("O triângulo é isósceles");
            }
        }
    }
}