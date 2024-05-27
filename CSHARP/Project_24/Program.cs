using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_24
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Verificar se o número é primo com o Input do utilizador

            int numero, temp, divisiveis = 0;

            Console.Write("Escreva um número para verificar se é primo:");
            numero = int.Parse(Console.ReadLine());
            Console.Write("\n");

            temp = numero;
            while (temp >= 1)
            {
                if (numero % temp == 0)
                {
                    divisiveis++;
                }
                temp--;
            }
            Console.WriteLine($"Divisiveis --> {divisiveis} \n");
            if (divisiveis == 2)
            {
                Console.WriteLine($"O número {numero} é primo.");
            } 
            if (divisiveis != 2)
            {
                Console.WriteLine($"O número {numero} não é primo.");
            }
        }
    }
}