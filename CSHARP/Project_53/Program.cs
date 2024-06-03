using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_53
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Chave do Euromilhões e colocar as chaves num ficheiro de texto

            //Variáveis
            string filePath = @"/Users/TiagoFonseca/Desktop/euromilhoes.txt";
            int num_Chaves = 0;
            int num_Gerado = 0;

            int[] numeros = new int[5];
            int[] estrelas = new int[2];

            Random aleatorio = new Random();

            FileInfo fi = new FileInfo(filePath);
            StreamWriter escrita = fi.CreateText();

            
            Console.WriteLine("Quantas chaves pretende gerar?");
            num_Chaves = int.Parse(Console.ReadLine());

            while (num_Chaves > 0)
            {
                escrita.WriteLine("------ Combinação Números -----");

                for (int i = 0; i < numeros.Length; i++)
                {
                    num_Gerado = aleatorio.Next(1, 51);
                    numeros[i] = num_Gerado;
                    escrita.Write($"{numeros[i]} ");
                }

                num_Gerado = 0;

                escrita.WriteLine("\n------ Combinação Estrelas -----");
                
                for (int i = 0; i < estrelas.Length; i++)
                {
                    num_Gerado = aleatorio.Next(1, 13);
                    estrelas[i] = num_Gerado;
                    escrita.Write($"{estrelas[i]} ");
                }
                escrita.WriteLine("\n\n");

                num_Chaves--;        
            }
            escrita.Close();

        }
    }
}
