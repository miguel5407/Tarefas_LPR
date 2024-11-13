using exercicio_3_andery;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Turma turma = new Turma();
        int escolha;

        do
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("1 - Adicionar Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            escolha  = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    turma.adicionarAluno();
                    break;

                case 2:
                    turma.listarAlunos();
                    break;

                case 0:
                    escolha = 0;
                    Console.WriteLine("Saindo do programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (escolha != 0);
    }
} using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3_andery
{
    public class Matricula
    {
        public int data;

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3_andery
{
    public class Aluno
    {
    public string Nome { get; set; }
    public int Ano { get; set; }
    public int idade {  get; set; } 
    public string identificacao { get; set; }
        public List<Matricula> matriculas = new List<Matricula>();
    public void adicionarMatricula()
        {
            Matricula m1 = new Matricula();
            Console.WriteLine("digite o nome do aluno");
            Nome = Console.ReadLine();
            Console.WriteLine("digite o ano de nascimento");
            Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a idade do aluno");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a identificação do aluno");
            identificacao = Console.ReadLine();
            Console.WriteLine("digite a data de matricula");
            m1.data = int.Parse(Console.ReadLine()); 
            matriculas.Add(new Matricula());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace exercicio_3_andery
{
    public class Turma
    {
    public List<Aluno> alunos = new List<Aluno>();
    Aluno g1 = new Aluno();
    Matricula m1 = new Matricula();
        public void adicionarAluno()
        {
            if (alunos.Any(aluno => aluno.identificacao == g1.identificacao))
            {
                Console.WriteLine("aluno ja cadastrado");
            }
            else
            {
                g1.adicionarMatricula();
                alunos.Add(g1);
            }
        }
        public void listarAlunos()
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado.");
                return;
            }
            Console.WriteLine($"{alunos}");
            Console.WriteLine("Lista de alunos:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Ano: {aluno.Ano}, Idade: {aluno.idade}, Identificação: {aluno.identificacao}");
            }
        }

    }
}