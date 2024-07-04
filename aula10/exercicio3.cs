using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Criação do Dicionário
        Dictionary<string, int> pessoas = new Dictionary<string, int>
        {
            {"Ana", 25},
            {"Bruno", 30},
            {"Carla", 22},
            {"Diego", 35},
            {"Eva", 28}
        };

        // 2. Cálculo da Média de Idades
        double media = pessoas.Values.Average();

        // 3. Encontrar e Imprimir Nomes com Idades Acima da Média
        Console.WriteLine("Pessoas com idade acima da média:");
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > media)
            {
                Console.WriteLine(pessoa.Key);
            }
        }

        // 4. Encontrar e Imprimir a Pessoa Mais Velha e a Mais Nova
        var pessoaMaisVelha = pessoas.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        var pessoaMaisNova = pessoas.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;

        Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelha}");
        Console.WriteLine($"Pessoa mais nova: {pessoaMaisNova}");

        // 5. Remover Pessoas com Idade Igual a Y e Imprimir Dicionário Atualizado
        Console.WriteLine("Digite a idade que deseja remover:");
        int idadeParaRemover = int.Parse(Console.ReadLine());

        var chavesParaRemover = pessoas.Where(p => p.Value == idadeParaRemover).Select(p => p.Key).ToList();
        foreach (var chave in chavesParaRemover)
        {
            pessoas.Remove(chave);
        }

        Console.WriteLine("Dicionário atualizado:");
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Key}: {pessoa.Value}");
        }
    }
}
