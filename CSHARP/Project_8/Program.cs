using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Determina o peso ideal baseado na altura em centimetros

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            double altura = 0;
            string genero = " ";

            Console.WriteLine("Escreva M para Masculino ou F para Feminino");
            genero = Console.ReadLine().ToUpper(); //Converte para Maiscula
            Console.WriteLine("\n");

            if (genero == "M")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Insira a sua altura em centimetros.");
                altura = double.Parse(Console.ReadLine());
                altura = altura / 100; //Converte a altura de centimetros para metros
                
                double pesoIdeal = (72.7 * altura) - 58.0;
                Console.WriteLine("\n");
                Console.WriteLine($"O seu peso ideal é {Math.Round(pesoIdeal, 2)}Kg.");
            }
            else if (genero == "F")
            {
                
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Insira a sua altura em centimetros.");
                altura = double.Parse(Console.ReadLine());
                altura = altura / 100; //Converte a altura de centimetros para metros
             
                double pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("\n");
                Console.WriteLine($"O seu peso ideal é {Math.Round(pesoIdeal, 2)}Kg");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("Caracter não válido");
            }
        }
    }
}
