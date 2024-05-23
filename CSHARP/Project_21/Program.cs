using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project21
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Descobrir o factorial de um número

            Console.ForegroundColor = ConsoleColor.DarkGray;
            int numero, resultado, numeroEcra;
            numero = 0;
            resultado = 1;

            Console.WriteLine("Escreva um número para saber o seu factorial");
            numero = int.Parse(Console.ReadLine());
            numeroEcra = numero;

            while (numero > 0)
            {
                resultado = resultado * numero;
                numero--;
            }
            Console.WriteLine($"\nO factorial de {numeroEcra} é {resultado}");
        }
    }
}
