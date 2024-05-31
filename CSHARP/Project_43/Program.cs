using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_43
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Melhoria do Projeto 42. Usando Funções do Sistema
            // Vamos Declarar array com 10 posições, mostrar os 
            // números e também selecionar os pares, maior, menor e primos

            int[] numeros = new int[10];
            Random aleatorio = new Random();

            Console.WriteLine("----- Todos os Números ------");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 1001);
                Console.Write($"{numeros[i]} ");
            }

            Console.WriteLine("\n\n----- Pares ------");
            for(int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }

            Console.WriteLine("\n\n------ Estatísticas ------");
            Console.WriteLine($"Menor: ---> {numeros.Min()}");
            Console.WriteLine($"Maior: ---> {numeros.Max()}");
            Console.WriteLine($"Média: ---> {numeros.Average()}");
            Console.WriteLine($"Soma: ---> {numeros.Sum()}");
            
            Console.WriteLine("\n\n------ Primos ------");
            for(int i = 0; i < numeros.Length; i++)
            {
                if(VerificaPrimo(numeros[i]) != "Não Primo")
                {
                    Console.Write(numeros[i] + " ");
                }
            }
        
        }

        static string VerificaPrimo(int num)
        {
            int divisiveis = 0;
            for(int i = num; i > 0; i--)
            {
                if(num % i == 0)
                {
                 divisiveis++;
                }
            }
            if(divisiveis <= 2)
            {
                return "Primo";
            }
            else
            {
                return "Não Primo";
            }
        }
       
    }
}   
