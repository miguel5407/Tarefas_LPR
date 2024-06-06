using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando o vetor principal
        int[] inteiros = new int[10];

        // Usando o for para leitura dos números
        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < inteiros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            inteiros[i] = int.Parse(Console.ReadLine());
        }

        // Criando os vetores para pares e ímpares
        int[] par = new int[10];
        int[] impar = new int[10];
        int countPar = 0;
        int countImpar = 0;

        // Separando os números em pares e ímpares
        for (int i = 0; i < inteiros.Length; i++)
        {
            if (inteiros[i] % 2 == 0)
            {
                par[countPar] = inteiros[i];
                countPar++;
            }
            else
            {
                impar[countImpar] = inteiros[i];
                countImpar++;
            }
        }

        // Exibindo os vetores de números pares
        Console.WriteLine("Vetor de números pares:");
        for (int i = 0; i < countPar; i++)
        {
            Console.Write(par[i] + " ");
        }
        Console.WriteLine();

        // Exibindo os vetores de números ímpares
        Console.WriteLine("Vetor de números ímpares:");
        for (int i = 0; i < countImpar; i++)
        {
            Console.Write(impar[i] + " ");
        }
        Console.WriteLine();
    }
}