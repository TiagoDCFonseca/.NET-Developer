using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Cálculo volume da esfera dado input do utilizador
            double raio;

            Console.WriteLine("Insira o valor do raio:");
            raio = double.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * Math.PI * (Math.Pow(raio, 3));
            Console.WriteLine($"Valor da variável raio: {raio}");
            Console.WriteLine($"O volume da esfera é: {volume}");
        }
    }
}
