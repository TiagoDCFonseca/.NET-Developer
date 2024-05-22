using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Utilizar o switch para testar condições
            //com valores inteiros.

            int num;
            Console.WriteLine("Escolhe um número entre 1 e 5");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Escolheste o número UM");
                    break;
                case 2:
                    Console.WriteLine("Escolheste o número DOIS");
                    break;
                case 3:
                    Console.WriteLine("Escolheste o número TRÊS");
                    break;
                case 4:
                    Console.WriteLine("Escolheste o número QUATRO");
                    break;
                case 5:
                    Console.WriteLine("Escolheste o número CINCO");
                    break;
                default:
                    Console.WriteLine("Escolha um número entre 1 e 5");
                    break;
            }
        }  
    }
}
