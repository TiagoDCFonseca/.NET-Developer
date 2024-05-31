using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_46
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exemplo de carregar vogais para dentro de um array
            // Da frase que escrevemos vamos só escrever as vogais

            char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'á', 'à', 'é', 'í', 'ó', 'ú', 'ã', 'â', 'ê', 'õ'};

            string frase = "Olá turma de Programação";

            for (int i = 0; i < frase.Length; i++)
            {
                if(vogais.Contains(frase[i]))
                {
                    Console.Write(frase[i]);
                }
            }
        }
    }
}