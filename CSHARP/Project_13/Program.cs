using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Operações com strings

            string frase;

            Console.WriteLine("Escreva uma frase");
            frase = Console.ReadLine();
                
            Console.WriteLine("\n\n-----Frase Original-----");
            Console.WriteLine(frase);

            Console.WriteLine("\n\n-----Frase em Maiscúlas-----");
            Console.WriteLine(frase.ToUpper());

            Console.WriteLine("\n\n-----Frase em minúsculas-----");
            Console.WriteLine(frase.ToLower());

            Console.WriteLine("\n\n-----Primeiros caractéres-----");
            Console.WriteLine(frase.Substring(0, 5)); // Apartir da posição 0 pega 5 caractéres

            Console.WriteLine("\n\n-----Posição de .Net-----");
            Console.WriteLine(frase.IndexOf(".Net")); // Retorna a posição onde começa .Net

            Console.WriteLine("\n\n-----Posição de a-----");
            Console.WriteLine(frase.IndexOf("a")); // Retorna a posição do 1º caractér a que encontra
        }
    }
}
