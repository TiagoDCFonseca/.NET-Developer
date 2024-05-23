using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Pedir ao utilizador para inserir um determinado texto e devolver o seguinte: 
             * • Nº total de vogais •
             * Nº total de não vogais (números, caracteres especiais e espaços) • 
             * Escrever o texto com as vogais a vermelho e os restantes caracteres a verde */

            string frase;
            int totalVogais = 0;
            string letra;

            Console.WriteLine("Escreva uma frase:");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                letra = frase.Substring(i, 1).ToLower();
                if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                {
                    totalVogais++;
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(letra);
            }
            Console.ResetColor();
            Console.WriteLine($"\n\nO total de vogais é: {totalVogais}");
            Console.WriteLine($"O total de consoantes é: {frase.Length - totalVogais}");
        }
    }
}
