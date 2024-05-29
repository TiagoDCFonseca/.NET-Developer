using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_41
{
    class MainClass
    {
        static int num_Adivinhar = 0, num_Utilizador = 0, tentativas = 0;
        static int dificuldade;
        static bool game_Over = false;
        static Random aleatorio = new Random();
        public static void Main(string[] args)
        {
            /* 
            Jogo desenvolvido em aula, de “adivinhar o nº”. 
             Objetivo será permitir logo de início perguntar se o utilizador 
             pretende jogar um dos seguintes modos: 
             • 1 – Fácil (Nº entre 1 e 100) 
             • 2 – Médio (Nº entre 1 e 1000) 
             • 3 – Difícil (Nº entre um mínimo e um máximo aleatórios) 
             No final do jogo, pergunta ao utilizador se quer jogar novamente, 
             em caso afirmativo volta ao menu inicial, caso contrário sai da aplicação. 
             */

             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("------ Adivinhe o Número ------");
             Console.ResetColor();
            
            while (game_Over == false)
            {
                Console.WriteLine("\nEscolha uma das seguintes opções:");
                Menu();
                dificuldade = int.Parse(Console.ReadLine());

                switch (dificuldade)
                {
                    case 1:
                        Facil();
                        break;
                    case 2:
                        Medio();
                        break;
                    case 3:
                        Dificil();
                        break;
                    case 4:
                    game_Over = true;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!");
                        break;
                }

                if (game_Over == false)
                {
                    Console.WriteLine("\nDeseja jogar novamente? (s/n)");
                    string resposta = Console.ReadLine().ToLower();
                    if (resposta == "n")
                    {
                        game_Over = true;
                    }
                }
            }
            
        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n----- MENU -----");
            Console.WriteLine("1 - Fácil ---> Números entre 1 e 100");
            Console.WriteLine("2 - Médio ---> Números entre 1 e 1000");
            Console.WriteLine("3 - Difícil ---> Números Aleatórios");
            Console.WriteLine("4 - Sair");
            Console.ResetColor();
        }

        static void Facil()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            num_Adivinhar = aleatorio.Next(1, 101);
            Console.WriteLine("Em que número estou a pensar?");
            
            while (num_Utilizador != num_Adivinhar)
            {
                tentativas++;
                Console.Write("\nEscreva um número: ");
                num_Utilizador = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (num_Adivinhar > num_Utilizador)
                {
                    Console.WriteLine("O número é maior");
                }
                else if (num_Adivinhar < num_Utilizador)
                {
                    Console.WriteLine("O número é menor");
                }
            }
            Console.WriteLine($"\nParabén acertaste em {tentativas} tentativas");
            Console.ResetColor();
        }
        static void Medio()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            num_Adivinhar = aleatorio.Next(1, 1001);
            Console.WriteLine("Em que número estou a pensar?");
            
            while (num_Utilizador != num_Adivinhar)
            {
                tentativas++;
                Console.Write("\nEscreva um número: ");
                num_Utilizador = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (num_Adivinhar > num_Utilizador)
                {
                    Console.WriteLine("O número é maior");
                }
                else if (num_Adivinhar < num_Utilizador)
                {
                    Console.WriteLine("O número é menor");
                }
            }
            Console.WriteLine($"\nParabén acertaste em {tentativas} tentativas");
            Console.ResetColor();
        }

        static void Dificil()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Random aleatorio2 = new Random();
            int min_Aleatorio = aleatorio2.Next(1, 50000);
            int max_Aleatorio = aleatorio2.Next(1, 50000);
            int aux;

            if (min_Aleatorio > max_Aleatorio)
            {
                aux = min_Aleatorio;
                min_Aleatorio = max_Aleatorio;
                max_Aleatorio = aux;
            }
            num_Adivinhar = aleatorio.Next(min_Aleatorio, max_Aleatorio);

            while (num_Utilizador != num_Adivinhar)
            {
                
                tentativas++;
                Console.Write("\nEscreva um número: ");
                num_Utilizador = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (num_Adivinhar > num_Utilizador)
                {
                    Console.WriteLine("O número é maior");
                }
                else if (num_Adivinhar < num_Utilizador)
                {
                    Console.WriteLine("O número é menor");
                }
            }
            Console.WriteLine($"\nParabén acertaste em {tentativas} tentativas");
            Console.ResetColor();
        }
    }
}
