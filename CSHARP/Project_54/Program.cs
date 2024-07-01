using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_54
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Manipulação de um ficheiro txt chamado backups
            // Menu/Listas/Construtores

            //Variáveis
            string tipo = "", data = "", estado = "";
            DateTime data_Formatada;
            int opcao = 0;

            //Pegar o caminho do ficheiro e abrir o streamreader
            string filePath = @"/Users/TiagoFonseca/Desktop/backups.txt";
            StreamReader leitura = new StreamReader(filePath);

            List<Backup> lst_backups = new List<Backup>(); //Cria a lista herdando o construtor da classe

            do
            {
                Menu();
                Console.Write("\n Qual a sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Write("\n");

                switch(opcao)
                {
                    case 1:
                        string linha;
                        while((linha = leitura.ReadLine()) != null)
                        {
                            tipo = linha.Substring(0, 1);
                            data = linha.Substring(1, 8);
                            data_Formatada = DateTime.ParseExact(data, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            estado = linha.Substring(10);

                            Backup bak = new Backup();
                            bak.AdicionarBackup(tipo, data_Formatada, estado);
                            lst_backups.Add(bak);
                        }
                        Console.WriteLine("Ficheiro carregado com sucesso!");
                        break;

                    case 2:
                        foreach(Backup b in lst_backups)
                        {
                            Console.WriteLine($"{b.Tipo} | {b.Data.ToString("yyyy-MM-dd")} | {b.Estado}");
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Prioritários: {lst_backups.Where(x => x.Tipo == "P").Count()}");
                        Console.WriteLine($"Normais: {lst_backups.Where(x => x.Tipo == "N").Count()}");
                        break;

                    case 4:
                        int ano_Atual = DateTime.Now.Year;
                        foreach(Backup b in lst_backups.Where(x => x.Estado.IndexOf("sucesso", StringComparison.OrdinalIgnoreCase) > 0 && x.Data.Year == ano_Atual))
                        {
                            Console.WriteLine($"{b.Tipo} | {b.Data} | {b.Estado}");
                        }
                        break;
                    case 5:
                        foreach (Backup b in lst_backups.Where((x) => x.Estado.Contains("Erro")))
                        {
                            Console.WriteLine($"{b.Tipo} | {b.Data.ToString("yyyy-MM-dd")} | {b.Estado}");
                        }
                        break;               
                }

            }
            while (opcao != 6);
            leitura.Close();

        }

        class Backup
        {
            public void AdicionarBackup(string f_Tipo, DateTime f_Data, string f_Estado)
            {
                Tipo = f_Tipo;
                Data = f_Data;
                Estado = f_Estado;
            }
            public string Tipo { get; set; }
            public DateTime Data { get; set; }
            public string Estado { get; set;}
        }

        public static void Menu()
        {
            Console.WriteLine("\n\n----------MENU----------");
            Console.WriteLine("1 --> Carregar ficheiro “backups.txt”");
            Console.WriteLine("2 --> Listar todos os backups(com e sem erro) existentes no ficheiro");
            Console.WriteLine("3 --> Apresentar os números totais de backups “Prioritários” e “Normais” de forma separada");
            Console.WriteLine("4 --> Listar backups com “Sucesso” do ano atual(calcular a partir da data de sistema)");
            Console.WriteLine("5 --> Listar os backups com “Erro”");
            Console.WriteLine("6 --> Sair");
        }
    }
}