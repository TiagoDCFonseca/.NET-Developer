using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_36
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Função recebe frase e retorna a frase ao contrário
            string frase_Original = "";
            Console.WriteLine("Escreva uma frase.");
            frase_Original = Console.ReadLine();

            Console.WriteLine(Frase_Reversa(frase_Original));
        }
        static string Frase_Reversa(string frase)
        {
            string frase_Invertida = "";
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                frase_Invertida += frase.Substring(i, 1);
            }
            return frase_Invertida;
        }  
    }
}
