using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_34
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Neste exemplo criamos uma função que verifica se os números são primos
            Console.WriteLine($"O nº 7 é primo? --> {VerificaPrimo(7)}");
            Console.WriteLine($"O nº 743 é primo? --> {VerificaPrimo(743)}");
            Console.WriteLine($"O nº 7323 é primo? --> {VerificaPrimo(7323)}");
            Console.WriteLine($"O nº 543 é primo? --> {VerificaPrimo(543)}");
            Console.WriteLine($"O nº 1676 é primo? --> {VerificaPrimo(1676)}");
            Console.WriteLine($"O nº 4 é primo? --> {VerificaPrimo(4)}");
        }
        static string VerificaPrimo(int numero)
        {
            int divisores = 0;
            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores++;
                }
            }
            if(divisores == 2)
            {
                return "O número é Primo";
            }
            else
            {
                return "O número não é primo";
            }
        }
    }
}
