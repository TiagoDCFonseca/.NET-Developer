using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_48
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Lista de números inteiros

            List<int> numeros = new List<int>();

            Random aleatorio = new Random();

            //Carregar Lista com números aleatórios
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(aleatorio.Next(0, 101));
            }

            Console.WriteLine("------ Todos os Números ------");
            foreach (int numero in numeros)
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\n------ Ordem Ascendente ------");
            foreach (int numero in numeros.OrderBy(x => x))
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\n------ Ordem Descendente ------");
            foreach (int numero in numeros.OrderByDescending(x => x))
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\n------ Só os Pares ------");
            foreach (int numero in numeros.Where(x => x % 2 == 0))
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\n------ Maiores que 50 ------");
            foreach (int numero in numeros.Where(x => x > 50))
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\n------ Maiores que 50 e Ordem Ascendente ------");
            foreach (int numero in numeros.OrderBy(x => x).Where(x => x > 50))
            {
                Console.Write($"{numero} ");
            }
        }
    }
}
