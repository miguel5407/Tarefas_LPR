public class Cliente
{
    public string Nome { get; set; }
    public List<string> Reservas = new List<string>();

    public void AdicionarReserva()
    {
        Console.WriteLine("Digite a quantidade de reservas que deseja adicionar:");
        int quantidadeDesejada = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeDesejada; i++)
        {
            Console.WriteLine("Adicione o valor da reserva:");
            string reservaAdicionada = Console.ReadLine();
            Reservas.Add(reservaAdicionada);
        }
    }

    public void ListarReserva()
    {
        Console.WriteLine("As reservas são:");
        foreach (var reserva in Reservas)
        {
            Console.WriteLine(reserva);
        }
    }
}
public class Reserva
{
    public Cliente Cliente { get; set; }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int escolha;
        Reserva r1 = new Reserva();
        Cliente c1 = new Cliente();

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Dizer o nome do cliente");
            Console.WriteLine("2. Adicionar reserva");
            Console.WriteLine("3. Listar reservas");
            Console.WriteLine("0. Sair");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Nome do cliente: " + c1.Nome);
                    break;

                case 2:
                    c1.AdicionarReserva();
                    break;

                case 3:
                    c1.ListarReserva();
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine(); // Adiciona uma linha em branco para organizar a saída

        } while (escolha != 0);
    }
}
