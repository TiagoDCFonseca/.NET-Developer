using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project17
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Um número é recíproco se o seu primeiro digito é igual ao último digito, 
             * o segundo digito é igual ao penultimo e assim sucessivamente.
             * Elabore um algoritmo que lê um número e determina se ele é ou não recíproco.
             * Exemplos: 123454321->Recíproco 123321->Recíproco 123432->Não recíproco*/
            
            string numOriginal = "", numInvertido = "";
            Console.WriteLine("Qual o número que deseja verificar:");
            numOriginal = Console.ReadLine();

            for (int i = numOriginal.Length - 1; i >= 0; i--)
            {
                numInvertido = numInvertido + numOriginal.Substring(i, 1);
            }
            Console.WriteLine($"Original: {numOriginal}");
            Console.WriteLine($"Invertido: {numInvertido}");

            if(numOriginal == numInvertido)
            {
                Console.WriteLine("\nÉ recíproco");
            }
            else
            {
                Console.WriteLine("\nNão é recíproco");
            }
        }  
    }
}
