using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace Project_40
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Criar um programa que receba a temperatura média de cada mês do ano, em centígrados, 
             * e armazene essas temperaturas num array.  x
             * Imprimir as temperaturas de 
             * tods os meses, a maior e a menor temperatura do ano e em que mês 
             * aconteceram.
             */

            int[] temperatura = new int[12];
            int maior = 0, menor = 60;

            temperatura[0] = 3;
            temperatura[1] = 10;
            temperatura[2] = 23;
            temperatura[3] = 28;
            temperatura[4] = 32;
            temperatura[5] = 38;
            temperatura[6] = 39;
            temperatura[7] = 27;
            temperatura[8] = 22;
            temperatura[9] = 20;
            temperatura[10] = 39;
            temperatura[11] = 22;

            string[] meses = new string[12];

            meses[0] = "Janeiro";
            meses[1] = "Fevereiro";
            meses[2] = "Março";
            meses[3] = "Abril";
            meses[4] = "Maio";
            meses[5] = "Junho";
            meses[6] = "Julho";
            meses[7] = "Agosto";
            meses[8] = "Setembro";
            meses[9] = "Outubro";
            meses[10] = "Novembro";
            meses[11] = "Dezembro";

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"\nO mês de {meses[i]} teve temperatura média de {temperatura[i]} graus");

                //Se A a temperatura dentro da posição i é maior que maior
                if (temperatura[i] > maior)
                {
                    //Maior recebe a temperatura da posição do i
                    maior = temperatura[i];
                }
                if (temperatura[i] < menor)
                {
                    menor = temperatura[i];
                }
            }


            Console.WriteLine($"\n\nMês Com Temperatura maior");

            for (int i = 0; i < 12; i++)
            {
                if (temperatura[i] == maior)
                {
                    Console.WriteLine($"{meses[i]} - {maior}ºC");
                }
            }

            Console.WriteLine($"Mês Com Temperatura menor");

            for (int i = 0; i < 12; i++)
            {
                if (temperatura[i] == menor)
                {
                    Console.WriteLine($"{meses[i]} - {menor}ºC");
                }
            }

        }


    }
}
