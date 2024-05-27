using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_29
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Programa que pede ao utilizador para inserir 5 números ímpares,
             * caso o utilizador insira pares a aplicação 
             * não deverá aceitar e pede um novo número ao utilizador.
             * Mostrar os números no ecran.
             */

            int numero = 0;
            string num_Texto = "";

            Console.WriteLine("Programa de números Impares");
            for (int i = 0; i < 5; i++)
            {
                numero = 2;
                while (numero % 2 == 0)
                {
                    Console.Write($"Insira o {i} número Impar: ");
                    numero = int.Parse(Console.ReadLine());
                }
                num_Texto = num_Texto + numero.ToString() + " ";
            }
            Console.WriteLine($"\n{num_Texto}");
        }
    }
}
