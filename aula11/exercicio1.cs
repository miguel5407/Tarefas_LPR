using System;

public class Retangulo
{
    public double altura;
    public double largura;

    // Construtor da classe
    public Retangulo(double altura, double largura)
    {
        this.altura = altura;
        this.largura = largura;
    }

    // Método para calcular a área
    public double CalcArea()
    {
        return altura * largura;
    }

    // Método para calcular o perímetro
    public double CalcPerimetro()
    {
        return 2 * (altura + largura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Entrada da altura
        Console.WriteLine("Insira a altura de um retângulo:");
        double altura = double.Parse(Console.ReadLine());

        // Entrada da largura
        Console.WriteLine("Insira a largura de um retângulo:");
        double largura = double.Parse(Console.ReadLine());

        // Mostra os valores de entrada
        Console.WriteLine($"A altura desse retângulo é: {altura} e a largura desse retângulo é: {largura}");

        // Cria uma instância de Retangulo
        Retangulo p1 = new Retangulo(altura, largura);

        // Calcula a área e o perímetro
        double area = p1.CalcArea();
        double perimetro = p1.CalcPerimetro();

        // Exibe a área e o perímetro
        Console.WriteLine($"A área do retângulo é {area} e seu perímetro é {perimetro}");
    }
}