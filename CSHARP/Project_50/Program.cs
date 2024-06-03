using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_50
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Array 10 nºs aleatorios e garante que não há números repetidos

            int[] numeros = new int[10];
            int index = 0, num_Gerado = 0;

            Random aleatorio = new Random();

            //Não existe nenhum nº repetido porque está na posição 0
            bool repetido = false;

            while (index < numeros.Length)
            {
                num_Gerado = aleatorio.Next(1, 12);
                repetido = false;

                //Ciclo para controlo de números repetidos
                for(int i = 0; i < numeros.Length; i++)
                {
                    // Se a posição de i for igual ao número gerado
                    if (numeros[i] == num_Gerado)
                    {
                        repetido = true;
                        break;
                    }
                  
                }

                // Se for falso. O index de numeros recebe o valor do num_Gerado
                if (!repetido)
                {
                    numeros[index] = num_Gerado;
                    index++;
                }
            }

            //Mostro no ecrâ
            foreach(int num in numeros)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
