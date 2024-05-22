using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Uma aplicação que gera 20 números aleatórios entre 1 e 300. 
             * No final apresenta, o maior, o menor e a média. */

            int numGerado, maior = 1, menor = 300, total = 0;

            Random aleatorio = new Random();

            for (int i = 0; i < 20; i++)
            {
                numGerado = aleatorio.Next(1, 301);
                Console.Write($"{numGerado} ");

                total = total + numGerado;

                if (numGerado > maior)
                {
                    maior = numGerado;
                }
                if (numGerado < menor)
                {
                    menor = numGerado;
                }

            }
            Console.WriteLine($"\n\nO número maior é: {maior}");
            Console.WriteLine($"\nO número menor é: {menor}");
            Console.WriteLine($"\nA média dos números é: {total/20}");
        }
    }
}
