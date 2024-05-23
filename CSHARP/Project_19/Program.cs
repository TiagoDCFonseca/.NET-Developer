using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ciclo de repetição For
            //Pergunta ao Utilizador quantos números pretende gerar
            //Gerar números aleatorios entre 1 e 100 e

            Console.ForegroundColor = ConsoleColor.Cyan;
            Random aleatorio = new Random();

            int numeros, numGerado;
            
            Console.WriteLine("Quantos números pretende gerar?");
            numeros = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            for(int i = 0; i <= numeros; i++)
            {
                numGerado = aleatorio.Next(1, 101);

                if(numGerado % 2 == 0) // Se for par muda cor para verde
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else // impar muda a cor para vermelho
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write($"{numGerado} ");
                System.Threading.Thread.Sleep(500); //Demora 500 milisegundos para imprimir o próximo número
            } 
        }
    }
}
