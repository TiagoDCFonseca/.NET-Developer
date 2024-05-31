using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_47
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Introdução a Listas

            //Declarar Lista
            List<string> cores = new List<string>();

            //Carregá-la com valores
            cores.Add("Preto");
            cores.Add("Amarelo");
            cores.Add("Branco");
            cores.Add("Vermelho");
            cores.Add("Cinzento");
            cores.Add("Castanho");
            cores.Add("Roxo");
            cores.Add("Laranja");
            cores.Add("Violeta");
            cores.Add("Turquesa");
            cores.Add("Azul");

            Console.WriteLine("----- Lista Original ------");
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine("\n\n----- Lista Ordenada Ascendente------");
            foreach (string cor in cores.OrderBy(x => x))
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine("\n\n----- Lista Ordenada Descendente ------");
            foreach (string cor in cores.OrderByDescending(x => x))
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine("\n\n----- Lista Ordenada Descendente ------");
            foreach (string cor in cores.OrderByDescending(x => x))
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine("\n\n----- Cores Começadas por A------");
            foreach (string cor in cores.Where(x => x.Substring(0, 1).ToUpper() == "A"))
            {
                Console.WriteLine(cor);
            }
        }
    }
}
