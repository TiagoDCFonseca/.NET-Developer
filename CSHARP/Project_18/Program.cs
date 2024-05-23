using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18
{
    class Program
    {
        public static void Main(string[] args)
        {
            int contador = 0;

            Console.WriteLine("-----Exemplo While-----");
            while(contador <= 20)
            {
                Console.WriteLine(contador);
                contador++;
            }
            contador = 0;
            Console.WriteLine("-----Exemplo Do While-----");
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while(contador <= 20);
        }
    } 
}
