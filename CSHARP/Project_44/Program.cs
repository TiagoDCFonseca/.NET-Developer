using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_44
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
                * Programa que popula um array de 10 posições. Nota Código pode ser
                alterado para pedir ao utilizador para inserir o nome de 10 pessoas e no final mostrar:
                * O nome das pessoas cujo o nome comece por uma vogal.
                * O nome das pessoas cujo o nº de caracteres seja superior a 20.
                * Mostrar tods os nomes, 1º caracter em maíusculas e tods os restantes em minúsculas.
            */

            string[] nomes = new string[10];

            nomes[0] = "Tiago Fonseca";
            nomes[1] = "Erika Nishida";
            nomes[2] = "Santiago Fonseca";
            nomes[3] = "Ana Dias";
            nomes[4] = "Felisberto Contenteeee";
            nomes[5] = "Umberto Silva";
            nomes[6] = "Isabella Ferreira";
            nomes[7] = "Joana Silva";
            nomes[8] = "otávio Percival";
            nomes[9] = "perry Ornitorrinco";

            Console.WriteLine("----- Todos os Nomes ------");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{nomes[i]}");
            }

            Console.WriteLine("\n\n----- Nomes Começando com Vogal ------");
            for (int i = 0; i < nomes.Length; i++)
            {
                if(nomes[i].ToLower().Substring(0, 1) == "a" || nomes[i].ToLower().Substring(0, 1) == "e" || nomes[i].ToLower().Substring(0, 1) == "i" || nomes[i].ToLower().Substring(0, 1) == "o" || nomes[i].ToLower().Substring(0, 1) == "u")
                {
                    Console.WriteLine($"{nomes[i]}");
                }
            }

            Console.WriteLine("\n\n------ Nomes Com Caractéres > 20 ------");
            foreach(string nome in nomes)
            {
                if(nome.Length > 20)
                {
                    Console.WriteLine($"{nome}");
                }
            }

            Console.WriteLine("\n\n--- Mostra todos os nomes, 1º Caractér Maisculo e os Restantes Minusculos ---");
            for(int i = 0; i < nomes.Length; i++)
            {
                ComecaMaiscula(nomes[i]);
            }

        }

        static void ComecaMaiscula(string nome)
        {
            string nome_Alterado = nome.ToString();
            string nome_Devolver = nome.Substring(0, 1).ToUpper() + nome.Substring(1).ToLower();
            Console.WriteLine(nome_Devolver);
        }
    }
}
