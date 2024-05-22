using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9
{
    class MainClass
    {
        public static void Main(string[] args)
        {   // Estruturas de decisão:
            // E  --> &&

            int numGerado = 0;
            Random aleatorio = new Random();
            numGerado = aleatorio.Next(1, 101);

            Console.WriteLine($"O número gerado foi: {numGerado}");

            if (numGerado >= 30 && numGerado <= 70)
            {
                Console.WriteLine($"O número {numGerado} está entre 30 e 70");
             
            }
            else if (numGerado < 30)
            {
                Console.WriteLine($"O número {numGerado} é menor que 30");
            }
            else
            {
                Console.WriteLine($"O número {numGerado} é maior 70");

            }
        }
    }
}
