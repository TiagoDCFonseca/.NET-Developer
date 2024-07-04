using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_55
{
    class MainClass
    {
        static int qtd_numeros_gerar = 0;
        static int valor_intervalo_min = 0, valor_intervalo_max = 0;
        static Random aleatorio = new Random(); 

        public static void Main(string[] args)
        {
            //Menu/Funções/Listas/EscreverFicheiros/CiclosRepetição

            int opcao = 0;
            List<int> lst_numeros = new List<int>();

            LeituraIntervalo();
            GerarNumerosAleatorios(lst_numeros);

            do
            {
                Menu();
                Console.WriteLine("\nQual a sua opção?");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        MostrarTodosNumeros(lst_numeros);
                        break;
                    case 2:
                        MostrarNumerosOrdenados(lst_numeros);
                        break;
                    case 3:
                        MostrarNumerosOrdenadosDesc(lst_numeros);
                    break;
                    case 4:
                        MostrarNumerosPares(lst_numeros);
                        break;
                    case 5:
                        CalcularSoma(lst_numeros);
                        break;
                    case 6:
                        Media(lst_numeros);
                        break;
                    case 7:
                        MostrarMaiorNumero(lst_numeros);
                        break;
                    case 8:
                        MostrarMenorNumero(lst_numeros);
                        break;
                    case 9:
                        MostrarTresMaioresNumeros(lst_numeros);
                        break;
                    case 10:
                        MostrarNumerosParesCrescente(lst_numeros);
                        break;
                    case 11:
                        EscreverPrimosTexto(lst_numeros);
                        break;
                    default:
                    break;
                }
            }
            while(opcao != 12);

        }

        static void Menu()
        {
            Console.WriteLine("-----------------MENU-----------");
            Console.WriteLine("• 1 - Apresentar todos os números");
            Console.WriteLine("• 2 - Apresentar nºs por ordem crescente");
            Console.WriteLine("• 3 - Apresentar nºs por ordem decrescente");
            Console.WriteLine("• 4 - Apresentar os números pares");
            Console.WriteLine("• 5 - O total da soma dos nºs");
            Console.WriteLine("• 6 - A média dos nºs");
            Console.WriteLine("• 7 - O nº maior");
            Console.WriteLine("• 8 - O nº mais pequeno");
            Console.WriteLine("• 9 - Os 3 nºs maiores ");
            Console.WriteLine("• 10 - Os nºs pares e por ordem crescente");
            Console.WriteLine("• 11 - Escrever os nºs primos num ficheiro “primos.txt”");
            Console.WriteLine("• 12 - Sair");
        }
        static void LeituraIntervalo()
        {
            int temp = 0;

            Console.WriteLine("Quantos números pretende gerar?");
            qtd_numeros_gerar = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o intervalo mínimo?");
            valor_intervalo_min = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o intervalo máximo?");
            valor_intervalo_max = int.Parse(Console.ReadLine());

            if(valor_intervalo_min > valor_intervalo_max)
            {
                temp = valor_intervalo_max;
                valor_intervalo_max = valor_intervalo_min;
                valor_intervalo_min = temp;
            }
        }

        static void GerarNumerosAleatorios(List<int> numerosLista)
        {
            for (int i = 0; i < qtd_numeros_gerar; i++)
            {
                numerosLista.Add(aleatorio.Next(valor_intervalo_min, valor_intervalo_max));
            }
        }

        static void MostrarTodosNumeros(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Todos os Números-------");
            foreach (int numero in numerosLista)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n\n");
        }
        
        static void MostrarNumerosOrdenados(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Todos os Números Ordem Crescente-------");
            foreach (int numero in numerosLista.OrderBy(x => x))
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n\n");
        }
        static void MostrarNumerosOrdenadosDesc(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Todos os Números Ordem Decrescente-------");
            foreach (int numero in numerosLista.OrderByDescending(x => x))
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n\n");
        }

        static void MostrarNumerosPares(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Todos os Números Pares-------");
            foreach (int numero in numerosLista.Where(x => x % 2 == 0))
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n\n");
        }

        static void MostrarNumerosParesCrescente(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Todos os Números Pares Crescente-------");
            foreach (int numero in numerosLista.Where(x => x % 2 == 0).OrderBy(x => x))
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n\n");
        }
        static void CalcularSoma(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Soma de Todos os Números-------");
            Console.WriteLine($"{numerosLista.Sum()}");
            Console.WriteLine("\n\n");
        }

        static void Media(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Media de Todos os Números-------");
            Console.WriteLine($"{numerosLista.Average()}");
            Console.WriteLine("\n\n");
        }

        static void MostrarMaiorNumero(List<int> numerosLista)
        {
            Console.WriteLine($"O Maior Número Gerado foi: {numerosLista.Max()}");
            Console.WriteLine("\n\n");
        }

        static void MostrarMenorNumero(List<int> numerosLista)
        {
            Console.WriteLine($"O Menor Número Gerado foi: {numerosLista.Min()}");
            Console.WriteLine("\n\n");
        }

        static void MostrarTresMaioresNumeros(List<int> numerosLista)
        {
            Console.WriteLine("\n\n-------Os 3 Maiores Números-------");
            foreach(int numero in numerosLista.OrderByDescending(x => x).Take(3))
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n\n");
        }

        static bool VerificaPrimo(int numero)
        {
            int divisores = 0;
            for (int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores++;
                }
            }
            if(divisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }                
        }

        static void EscreverPrimosTexto(List<int> numerosLista)
        {
            FileInfo fi = new FileInfo(@"/Users/TiagoFonseca/Desktop/Primos.txt");
            StreamWriter escrita = fi.CreateText();
            escrita.WriteLine("--------Números Primos-----------");

            foreach(int num in numerosLista)
            {
                if(VerificaPrimo(num))
                {
                    escrita.Write($"{num} ");
                }
            }
            escrita.Close();
            Console.WriteLine("\nFicheiro criado com sucesso!!");
        }
    }
}