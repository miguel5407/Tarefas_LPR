using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quantos nomes deseja inserir?");
        int numeroNomes = int.Parse(Console.ReadLine());
        
        List<string> nomes = new List<string>();
        
        for (int i = 0; i < numeroNomes; i++)
        {
            Console.WriteLine($"Digite o nome {i + 1}:");
            nomes.Add(Console.ReadLine());
        }
        
        var nomesOrdenados = nomes
            .Select((nome, index) => new { Nome = nome, Index = index })
            .OrderBy(x => x.Nome.Length)
            .ThenBy(x => x.Index)
            .Select(x => x.Nome)
            .ToList();
        
        List<List<string>> linhas = new List<List<string>>();
        Dictionary<int, int> tamanhoUltimaPosicao = new Dictionary<int, int>();
        
        for (int i = 0; i < nomesOrdenados.Count; i++)
        {
            var nome = nomesOrdenados[i];
            int tamanho = nome.Length;
            
            if (!tamanhoUltimaPosicao.ContainsKey(tamanho))
            {
                tamanhoUltimaPosicao[tamanho] = 0;
            }
            
            int linha = tamanhoUltimaPosicao[tamanho];
            
            if (linhas.Count <= linha)
            {
                linhas.Add(new List<string>());
            }
            
            linhas[linha].Add(nome);
            tamanhoUltimaPosicao[tamanho]++;
        }
        
        for (int i = 0; i < linhas.Count; i++)
        {
            Console.WriteLine(string.Join(" ", linhas[i]));
        }
    }
}