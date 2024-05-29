using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_37
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Introdução aos Arrays

            int[] valores = new int[5]; // Array com tamanho de 5 posições

            // Atribuir valores a cada posição
            valores[0] = 10;
            valores[1] = 20;
            valores[2] = 30;
            valores[3] = 40;
            valores[4] = 50;

            // Percorre o array e escreve no ecrâ

            for(int i = 0; i < valores.Length; i++)
            {
                Console.Write($"{valores[i]} ");
            }      
        }
    }
}
