using System;
namespace Project_3
{
    class MainClass
    {cle
        public static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("Insira o primeiro número.");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número.");
            num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;

            Console.WriteLine($"A soma de {num1} + {num2} é igual a {soma}." );
            Console.WriteLine($"A soma de {num1} + {num2} é igual a {num1 + num2}.");
            
        }
    }
}