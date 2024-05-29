using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_38
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Arrays com nomes

            string[] formandos = new string[6];
            formandos[0] = "Luis Soares";
            formandos[1] = "Tiago Fonseca";
            formandos[2] = "Erika Nishida";
            formandos[3] = "Verónica Mestre";
            formandos[4] = "Paulo Pinto";
            formandos[5] = "Santiago Fonseca";

            // Gerar um número aleatório entre o min e max do array
            Random aleatorio = new Random();
            int num_Gerado = aleatorio.Next(0, 6);

            //Escreve o nome do formando pegando o número aleatório
            Console.WriteLine(formandos[num_Gerado]);
        }
    }
}
