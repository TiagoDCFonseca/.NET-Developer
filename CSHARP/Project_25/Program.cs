using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_25
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Programa que converte segundos para horas e minutos.

            int horas = 0, minutos = 0, segundos = 0;

            Console.Write("Insira os segundos totais de execução: ");
            segundos = int.Parse(Console.ReadLine());
            Console.Write("\n");

            while (segundos >= 3600)
            {
                segundos = segundos - 3600;
                horas++;
            }
            while (segundos >= 60)
            {
                segundos = segundos - 60;
                minutos++;
            }
            Console.WriteLine($"Demora {horas}h:{minutos}m:{segundos}s");
        }
    }
}
