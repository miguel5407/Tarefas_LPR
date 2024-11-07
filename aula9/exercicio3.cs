using System;

class Program
{
    struct Heroi
    {
        public string Nome;
        public string Poder;
        public int Pontuacao;
    }

    static Heroi a1, a2, a3, a4, a5;
    static Heroi equipe1, equipe2, equipe3;

    static void Main(string[] args)
    {
        while (true)
        {
            MenuPrincipal();
        }
    }

    static void CadastrarHeroi()
    {
        Console.WriteLine("Cadastro do herói 1:");
        Console.Write("Nome: ");
        a1.Nome = Console.ReadLine();
        Console.Write("Poder: ");
        a1.Poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        a1.Pontuacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Cadastro do herói 2:");
        Console.Write("Nome: ");
        a2.Nome = Console.ReadLine();
        Console.Write("Poder: ");
        a2.Poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        a2.Pontuacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Cadastro do herói 3:");
        Console.Write("Nome: ");
        a3.Nome = Console.ReadLine();
        Console.Write("Poder: ");
        a3.Poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        a3.Pontuacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Cadastro do herói 4:");
        Console.Write("Nome: ");
        a4.Nome = Console.ReadLine();
        Console.Write("Poder: ");
        a4.Poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        a4.Pontuacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Cadastro do herói 5:");
        Console.Write("Nome: ");
        a5.Nome = Console.ReadLine();
        Console.Write("Poder: ");
        a5.Poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        a5.Pontuacao = int.Parse(Console.ReadLine());
    }

    static void SelecionarEquipe()
    {
        Console.WriteLine("Selecione 3 heróis para sua equipe:");
        ExibirHerois();

        Console.Write("Escolha o herói 1: ");
        equipe1 = EscolherHeroi();
        Console.Write("Escolha o herói 2: ");
        equipe2 = EscolherHeroi();
        Console.Write("Escolha o herói 3: ");
        equipe3 = EscolherHeroi();
    }

    static Heroi EscolherHeroi()
    {
        int escolha = int.Parse(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                return a1;
            case 2:
                return a2;
            case 3:
                return a3;
            case 4:
                return a4;
            case 5:
                return a5;
            default:
                Console.WriteLine("Escolha inválida. Tente novamente.");
                return EscolherHeroi();
        }
    }

    static void ExibirHerois()
    {
        Console.WriteLine("1. " + a1.Nome + " - " + a1.Poder + " - Pontuação: " + a1.Pontuacao);
        Console.WriteLine("2. " + a2.Nome + " - " + a2.Poder + " - Pontuação: " + a2.Pontuacao);
        Console.WriteLine("3. " + a3.Nome + " - " + a3.Poder + " - Pontuação: " + a3.Pontuacao);
        Console.WriteLine("4. " + a4.Nome + " - " + a4.Poder + " - Pontuação: " + a4.Pontuacao);
        Console.WriteLine("5. " + a5.Nome + " - " + a5.Poder + " - Pontuação: " + a5.Pontuacao);
    }

    static int CalcularPontuacaoTotal()
    {
        return equipe1.Pontuacao + equipe2.Pontuacao + equipe3.Pontuacao;
    }

    static void ExibirEquipe()
    {
        Console.WriteLine("Equipe selecionada:");
        Console.WriteLine("1. " + equipe1.Nome + " - " + equipe1.Poder + " - Pontuação: " + equipe1.Pontuacao);
        Console.WriteLine("2. " + equipe2.Nome + " - " + equipe2.Poder + " - Pontuação: " + equipe2.Pontuacao);
        Console.WriteLine("3. " + equipe3.Nome + " - " + equipe3.Poder + " - Pontuação: " + equipe3.Pontuacao);
        Console.WriteLine("Pontuação total da equipe: " + CalcularPontuacaoTotal());
    }

    static void MenuPrincipal()
    {
        Console.WriteLine("Menu Principal:");
        Console.WriteLine("1. Cadastro de heróis");
        Console.WriteLine("2. Seleção de equipe");
        Console.WriteLine("3. Exibição da equipe");
        Console.WriteLine("4. Sair do programa");
        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadastrarHeroi();
                break;
            case 2:
                SelecionarEquipe();
                break;
            case 3:
                ExibirEquipe();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}