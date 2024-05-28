using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_35
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exemplo de uma função tipo void para retornar um menu.
            
            Menu(); // Chamar a função e podemos chamá-la quantas vezes que necessitamos
            Console.WriteLine($"\n\nMenu outra vez");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("------ MENU ------");
            Console.WriteLine("Opção 1 ----> Ler Ficheiro");
            Console.WriteLine("Opção 2 ----> Copiar");
            Console.WriteLine("Opção 3 ----> Colar");
            Console.WriteLine("Opção 4 ----> Cortar");
            Console.WriteLine("Opção 5 ----> Imprimir");
            Console.WriteLine("Opção 6 ----> Sair");
        }
    }
}
