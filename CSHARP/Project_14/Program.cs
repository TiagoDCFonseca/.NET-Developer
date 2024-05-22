using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa para dividir a a string em partes

            string data;

            Console.WriteLine("Escreva uma data(dd/mm/aaaa)");
            data = Console.ReadLine();
            
            //Começando da posição da string 0 quero 2 caracteres para a frente
            Console.WriteLine($"Dia: {data.Substring(0, 2)}");

            //Começando da posição da string 3 quero 2 caracteres para a frente
            Console.WriteLine($"Mês: {data.Substring(3, 2)}");

            //Começando da posição da string 6 quero 4 caracteres para a frente
            Console.WriteLine($"Ano: {data.Substring(6, 4)}");

        }
    }
}