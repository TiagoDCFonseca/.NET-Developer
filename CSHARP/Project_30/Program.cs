using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_30
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Programa que guarda nomes em variáveis e retorna qual
            o maior nome e o nome mais curto*/

            string nome1, nome2, nome3, nome4, nome5;
            int caracter_min = 100, caracter_max = 0;

            Console.WriteLine("Escreva o nome 1.");
            nome1 = Console.ReadLine();
            Console.WriteLine("Escreva o nome 2.");
            nome2 = Console.ReadLine();
            Console.WriteLine("Escreva o nome 3.");
            nome3 = Console.ReadLine();
            Console.WriteLine("Escreva o nome 4.");
            nome4 = Console.ReadLine();
            Console.WriteLine("Escreva o nome 5.");
            nome5 = Console.ReadLine();

            if (nome1.Length > caracter_max)
                caracter_max = nome1.Length;
            if (nome1.Length < caracter_min)
                caracter_min = nome1.Length;
                
            if (nome2.Length > caracter_max)
                caracter_max = nome2.Length;
            if (nome2.Length < caracter_min)
                caracter_min = nome2.Length;
                
            if (nome3.Length > caracter_max)
                caracter_max = nome3.Length;
            if (nome3.Length < caracter_min)
                caracter_min = nome3.Length;
                
            if (nome4.Length > caracter_max)
                caracter_max = nome4.Length;
            if (nome4.Length < caracter_min)
                caracter_min = nome4.Length;
                
            if (nome5.Length > caracter_max)
                caracter_max = nome5.Length;
            if (nome5.Length < caracter_min)
                caracter_min = nome5.Length;

            Console.WriteLine("------ Nomes mais compridos -------");
            if(nome1.Length == caracter_max)
                Console.WriteLine(nome1);
            if(nome2.Length == caracter_max)
                Console.WriteLine(nome2);
            if(nome3.Length == caracter_max)
                Console.WriteLine(nome3);
            if(nome4.Length == caracter_max)
                Console.WriteLine(nome4);
            if(nome5.Length == caracter_max)
                Console.WriteLine(nome5);

            Console.WriteLine("\n\n------ Nomes mais curtos -------");
            if(nome1.Length == caracter_min)
                Console.WriteLine(nome1);
            if(nome2.Length == caracter_min)
                Console.WriteLine(nome2);
            if(nome3.Length == caracter_min)
                Console.WriteLine(nome3);
            if(nome4.Length == caracter_min)
                Console.WriteLine(nome4);
            if(nome5.Length == caracter_min)
                Console.WriteLine(nome5);
        }
    }
}
