using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           //Chave do EuroMilhões 5 numeros de 1 a 50 e 2 estrelas de 1 a 12 
           Console.ForegroundColor = ConsoleColor.Cyan;
           Random combinacao = new Random();

           int numeros, estrelas, numChaves = 0;
           int numChavesEcra = 0;

           Console.WriteLine("Quantas chaves do Euromilhões pretendes gerar?");
           numChaves = int.Parse(Console.ReadLine());
           numChavesEcra = numChaves;
           Console.WriteLine("\n");

           for (int i = 0; i < numChaves; i++)
           {
            Console.WriteLine($"\nChave do EuroMilhões número --> {numChavesEcra}\n");

            Console.WriteLine("Combinação de Números");
            for (int j = 0; j < 5; j++)
            {
                numeros = combinacao.Next(1, 51);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{numeros} ");
                System.Threading.Thread.Sleep(500);
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n");
            Console.WriteLine("Combinação de Estrelas");
            for(int j = 0; j < 2; j++)
            {
                estrelas = combinacao.Next(1, 13);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{estrelas} ");
                System.Threading.Thread.Sleep(500);
            }
            numChavesEcra--;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
           }
        }
    }
}
