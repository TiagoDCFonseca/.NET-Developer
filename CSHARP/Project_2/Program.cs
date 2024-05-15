using System;

namespace Project_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Variávei
            int idade = 0;
            string nome = "";

            //Escreve no ecrâ
            Console.WriteLine("Insira o seu nome:");
            //Guarda o input do utilizador na variável nome
            nome = Console.ReadLine();

            //Como o valor que pretendemos guardar é um número 
            //por isso convertemos antes de guardar na variável
            Console.WriteLine("Insira a sua idade:");
            idade = int.Parse(Console.ReadLine());

            //Quebras de linha
            Console.WriteLine("\n\n");

            //Formas de mostrar variáveis no ecrâ
            Console.WriteLine("O teu nome é " + nome + " e tens " + idade + " anos de idade.");
            Console.WriteLine("O teu nome é {0} e tens {1} anos de idade.", nome, idade);
            Console.WriteLine($"O teu nome é {nome} e tens {idade} anos de idade.");
        }
    }
}
