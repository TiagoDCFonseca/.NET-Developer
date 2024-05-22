using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Pede ao utilizador para inserir o número do mês 
            //do mês correspondente e o programa diz o nome

            int mes;
            Console.WriteLine("Insira o número do mês para obter o nome:");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1)
            {
                Console.WriteLine($"O mês {mes} corresponde a Janeiro");
            }
            else if (mes == 2)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Fevereiro");
            }
            else if(mes == 3)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Março");
            }
            else if(mes == 4)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Abril");
            }
            else if(mes == 5)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Maio");
            }

            else if(mes == 6)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Junho");
            }
            else if(mes == 7)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Julho");
            }
            else if(mes == 8)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Agosto");
            }
            else if(mes == 9)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Setembro");
            }
            else if(mes == 10)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Outubro");
            }
            else if(mes == 11)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Novembro");
            }
            else if(mes == 12)
            {
                
                Console.WriteLine($"O mês {mes} corresponde a Dezembro");
            }
            else
            {
                Console.WriteLine("Entrada não válida. Mês tem que ser entre 1 e 12");
            }
            
        }
    }
}