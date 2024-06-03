using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_51
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Lista de Objectos || Intro a Classes

            List<formando> lst_formandos = new List<formando>();

            //Adicionar um formando manualmente
            formando f1 = new formando();
            f1.Nome = "Tiago Fonseca";
            f1.Morada = "Rua X";
            f1.Idade = 29;
            lst_formandos.Add(f1);

            // Usando o Construtor
            formando f2 = new formando();
            f2.AdicionaFormando("Erika Nishida", "Rua X", 30);
            lst_formandos.Add(f2);

            formando f3 = new formando();
            f3.AdicionaFormando("Santiago Fonseca", "Rua X", 8);
            lst_formandos.Add(f3);

            formando f4 = new formando();
            f4.AdicionaFormando("Adalberto Silva", "Rua Y", 69);
            lst_formandos.Add(f4);


            //Mostrar Lista no Ecrâ
            Console.WriteLine("------ Lista de Formandos ------");
            foreach(formando form in lst_formandos)
            {
                Console.WriteLine($"{form.Nome} --> {form.Morada} --> {form.Idade}");
            }

            Console.WriteLine("\n\n------ Lista de Formandos - Ascendente ------");
            foreach(formando form in lst_formandos.OrderBy(f => f.Idade))
            {
                Console.WriteLine($"{form.Nome} --> {form.Morada} --> {form.Idade}");
            }

            Console.WriteLine("\n\n------ Lista de Formandos - Descendente ------");
            foreach(formando form in lst_formandos.OrderByDescending(f => f.Idade))
            {
                Console.WriteLine($"{form.Nome} --> {form.Morada} --> {form.Idade}");
            }

            Console.WriteLine("\n\n------ Lista de Formandos - Maiores de 25 Anos ------");
            foreach(formando form in lst_formandos.Where(f => f.Idade > 25))
            {
                Console.WriteLine($"{form.Nome} --> {form.Morada} --> {form.Idade}");
            }
        }

        class formando
        {
            //Construtor para adicionar formandos a lista
            public void AdicionaFormando(string f_Nome, string f_Morada, int f_Idade)
            {
                Nome = f_Nome;
                Morada = f_Morada;
                Idade = f_Idade;
            }
            public string Nome { get; set; }
            public string Morada { get; set; }
            public int Idade { get; set; }
        }
    }
}