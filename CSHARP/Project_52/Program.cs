using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_52
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Manipulação de ficheiros(Criação, Eliminação, Leitura e Escrita)

            //Leitura de ficheiros numa pasta
            DirectoryInfo pasta = new DirectoryInfo(@"/Users/TiagoFonseca/Desktop"); // Caminho para onde se encontra a pasta
            FileInfo[] ficheiros = pasta.GetFiles("*.*"); // Pega todos os ficheiros com todas as extensões. Nota a minha pasta no desktop se chama ficheiros

            Console.WriteLine("Todos os Ficheiros da pasta ficheiros");
            foreach (FileInfo fich in ficheiros)
            {
                Console.WriteLine($"{fich.Name} --> {fich.CreationTime} --> {fich.Length}Kb");
            }
            Console.WriteLine("\n\n");

            //Criar Ficheiros numa pasta
            string filePath = @"/Users/TiagoFonseca/Desktop/Teste.txt"; // Criar ficheiro Teste.txt no Desktop
            FileInfo f1 = new FileInfo(filePath);
            using (FileStream fstr = f1.Create())
            {
                //Cria o ficheiro vazio. Outra lógicas ou texto pode ser inserido aqui.
            }

            // Vamos Aproveitar a variavel que chamamos de filePath que guardou o caminho que a gente quer ir para escrever no ficheiro teste
            using (StreamWriter escrita = new StreamWriter(filePath))
            {
                escrita.WriteLine("A minha primeira Linha");
                escrita.WriteLine("Segunda Linha");
                escrita.WriteLine("Terceira Linha");
                escrita.Close();
            }

            
            Console.WriteLine("Ler o conteudo de um ficheiro para mostrar na Consola");
            using (StreamReader leitura = new StreamReader(filePath))
            {
                string line;
                while ((line = leitura.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("\n\nExcluir um Ficheiro");
            //Excluir o Ficheiro
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"\nO ficheiro {filePath} foi excluido com sucesso!");
            }

        }
    }
}
