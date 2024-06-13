using System;
class Program{
    public struct Produto{
        public string Nome;
        public int Codigo;
        public float Preco;
        public int Quantidade;
        
    }
     static void Main(){
    Console.WriteLine("digite os dados do primeiro produto: ");
     Produto a1;
     Console.Write("1. nome do produto: ");
     a1.Nome = Console.ReadLine();
     Console.Write("2. codigo do produto: ");
     a1.Codigo = int.Parse(Console.ReadLine());
     Console.Write("3. preco do produto: ");
     a1.Preco = float.Parse(Console.ReadLine());
     Console.Write("4. quantidade do produto: ");
     a1.Quantidade = int.Parse(Console.ReadLine());
     Console.WriteLine("digite os dados do segundo produto: ");
     Produto a2;
     Console.Write("1. nome do produto: ");
     a2.Nome = Console.ReadLine();
     Console.Write("2. codigo do produto: ");
     a2.Codigo = int.Parse(Console.ReadLine());
     Console.Write("3. preco do produto: ");
     a2.Preco = float.Parse(Console.ReadLine());
     Console.Write("digite os dados do terceiro produto: ");
     Console.Write("4. quantidade do produto: ");
     a2.Quantidade = int.Parse(Console.ReadLine());
     Produto a3;
     Console.Write("1. nome do produto: ");
     a3.Nome = Console.ReadLine();
     Console.Write("2 codigo do produto: ");
     a3.Codigo = int.Parse(Console.ReadLine());
     Console.Write("3. preco do produto: ");
     a3.Preco = float.Parse(Console.ReadLine());
     Console.Write("4. quantidade do produto: ");
     a3.Quantidade = int.Parse(Console.ReadLine());
     float precoTotal = a1.Quantidade * a1.Preco +  a2.Preco * a2.Quantidade + a3.Preco * a3.Quantidade;
     Console.WriteLine($"o valor total é: {precoTotal}");
     }
}