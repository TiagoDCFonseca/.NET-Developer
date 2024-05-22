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

            //Enquanto o i < 20 que é a quantidade de vezes que queremos executar o ciclo
            // e incrementamos o i para passar ao ciclo seguinte
            for (int i = 0; i < 20; i++)
            {
                numGerado = aleatorio.Next(1, 301);
                Console.Write($"{numGerado} ");

                total = total + numGerado;
                
                //Se o número gerado é maior que o valor da variável maior
                if (numGerado > maior)
                {
                    maior = numGerado;
                }
                //Se o número gerado é menor que o valor da variável menor
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
