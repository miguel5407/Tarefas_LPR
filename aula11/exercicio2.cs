using System;
public class Funcionario{
public string nome;
public double salarioBruto;
public double imposto;
public Funcionario(){
this.nome = nome;
this.salarioBruto = salarioBruto;
AplicarImposto();
}
public double CalcularSalarioLiquido(){
return salarioBruto - imposto;
    
}
public double AumentarSalario(double percentual){
return salarioBruto += salarioBruto*percentual / 100;
AplicarImposto();    
    
}
public void AplicarImposto(){
if(salarioBruto <= 2000){
imposto = salarioBruto * 0.1;
}    
else if(salarioBruto <= 3000){
imposto = salarioBruto *   0.15;
}
else{
imposto = salarioBruto * 0.2;
}
}
public void mostrarDados()
{
Console.WriteLine($"o salario é: {salarioBruto}, o nome é {nome} e o imposto é: {imposto}");
}
public void setNome(string nome){
this.nome = nome;
}
public void setSalario(double salario){
this.salarioBruto = salarioBruto;
AplicarImposto();
}
}
class Program{
static void Main(string[] args)
{
Funcionario s1 = new Funcionario();
Console.WriteLine("digite o seu nome");
s1.nome = Console.ReadLine();
Console.WriteLine("digite o seu salario");
s1.salarioBruto = double.Parse(Console.ReadLine());
s1.CalcularSalarioLiquido();
Console.WriteLine("digite o percentual");
double percentual = double.Parse(Console.ReadLine());
s1.AumentarSalario(percentual);
s1.AplicarImposto();
s1.mostrarDados();
}
}