using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_31
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
                Program que lê duas strings inseridas pelo utilizador
                e gera uma terceira string intercalando os caractéres de ambas.
                Exemplo string a = Programação, string b = curso.
                Output string c = Pcruorgsroamação
            */

            string a, b, c = "";

            Console.WriteLine("Escreva uma palavra.");
            a = Console.ReadLine();
            Console.WriteLine("Escreva outra palavra.");
            b = Console.ReadLine();

            if(a.Length >= b.Length)
            {
                for(int i = 0; i < b.Length; i++)
                {
                    c+= a.Substring(i, 1);
                    c+= b.Substring(i, 1);
                }
                c+= a.Substring(b.Length);
            }
            else
            {
                for(int i = 0; i < a.Length; i++)
                {
                    c+= b.Substring(i, 1);
                    c+= a.Substring(i, 1);
                }
                c+= b.Substring(a.Length);
            }
            Console.Write(c);
        }  
    }
}
