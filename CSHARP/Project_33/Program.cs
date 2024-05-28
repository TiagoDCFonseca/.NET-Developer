using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_33
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Introdução ás funções

            Console.WriteLine($"A soma de 5 mais 6 é: {soma(5,6)}"); //Chamamos a função e passamos os parametros
            Console.WriteLine($"A soma de 50 mais 63 é: {soma(50,63)}");
            Console.WriteLine($"A soma de 500 mais 16 é: {soma(500,16)}");
            Console.WriteLine($"A soma de 50000 mais 96 é: {soma(50000,96)}");
            Console.WriteLine($"A soma de 455 mais 86 é: {soma(455,86)}");
            Console.WriteLine($"A soma de 25 mais 76 é: {soma(25,76)}");
        }
        //Criada fora da funcão main mas dentro da MainClass
        static int soma(int num1, int num2) // Função chamada soma que retorna o valor da soma entre o num1 e num2
        {
            return num1 + num2;
        }
    }
}
