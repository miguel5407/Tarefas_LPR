using exercicio_livro_get_e_set;
using System;

class Program
{
    static void Main(string[] args)
    {
        int escolha;
        do
        {
            Biblioteca b1 = new Biblioteca();
            Console.WriteLine("bem vindo  a biblioteca ");
            Console.WriteLine("1. AdicionarLivro");
            Console.WriteLine("2. ListarLivros");
            Console.WriteLine("3. sair");
            Console.WriteLine("escolha uma opção");
             escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    b1.adicionarLivro();
                    break;

                case 2:
                    b1.listarlivros();
                    break;
                case 3:
                    Console.WriteLine("tenha um ótimo dia");
                    break;
                default:
                    Console.WriteLine("tente de novo");
                    break;

            }
        } while (escolha != 3);
}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_livro_get_e_set
{
    public class Biblioteca
    {
        public List<Livro> Livros = new List<Livro>();
        public void adicionarLivro()
        {
            Livro livroNovo = new Livro();
            Console.WriteLine("digite o titulo do seu livro");
            livroNovo.Titulo = Console.ReadLine();
            Console.WriteLine("digite o autor do seu livro");
            livroNovo.Autor = Console.ReadLine();
            Console.WriteLine("digite o ano de lançamento do seu livro");
            livroNovo.Ano = int.Parse(Console.ReadLine());
            Livros.Add(livroNovo);
            Console.WriteLine("livro adicionado com sucesso");
        }
        public void listarlivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }
            else
            {
                Console.WriteLine("Livros na biblioteca:");
                foreach (var livro in Livros)
                {
                    Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}");
                }
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_livro_get_e_set
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

    }
}