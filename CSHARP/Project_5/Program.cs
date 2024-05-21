using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Estruturas de decisão

            int num;
            
            Console.WriteLine("Escolha um número entre 1 e 100");
            num = int.Parse(Console.ReadLine());

            if(num > 50)
            {
                Console.WriteLine("O número é maior que 50");          
            }
            else if(num < 50)
            {
                Console.WriteLine("O número é inferior a 50");
            }
            else
            {
                Console.WriteLine("O número é igual a 50");
            }
        }
    }
}
