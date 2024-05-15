using System;

namespace Project_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Escrever Linhas no ecrã e mudar a cor
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exemplo de uma linha");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Exemplo de mais uma linha");
        }
    }
}
