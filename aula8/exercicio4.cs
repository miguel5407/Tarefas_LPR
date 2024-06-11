using System;

class Program
{
    static void Main(string[] args)
    {
        // Definindo o tamanho das matrizes
        int tamanho = 3;

        // Declarando as matrizes A, B e C (resultado)
        int[,] A = new int[tamanho, tamanho];
        int[,] B = new int[tamanho, tamanho];
        int[,] C = new int[tamanho, tamanho];

        // Lendo a matriz A
        Console.WriteLine("Digite os elementos da matriz A (3x3):");
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"A[{i + 1},{j + 1}]: ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Lendo a matriz B
        Console.WriteLine("Digite os elementos da matriz B (3x3):");
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"B[{i + 1},{j + 1}]: ");
                B[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Calculando a multiplicação das matrizes A e B, armazenando em C
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                C[i, j] = 0; // Inicializando o elemento de C
                for (int k = 0; k < tamanho; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Exibindo a matriz resultante C
        Console.WriteLine("Matriz C (resultado da multiplicação A * B):");
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(C[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}