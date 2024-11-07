using System;
class Aluno{
public int matricula;
public string nome;
public int prova1;
public int prova2;
public int trabalho;
public double media;
public Aluno(){
this.matricula = matricula;
this.nome = nome;
this.prova1 = prova1;
this.prova2 = prova2;
this.trabalho = trabalho;
this.media = media;
}
public void Media(){
 media = ((prova1*2.5) + (prova2*2.5) + (trabalho*2)) / 7;;
}
public void final(){
Media();
double final = 10 - media;
if(media < 7){
Console.WriteLine($"voce precisa de {final} pontos para a aprovação");
}
else if(media  >= 7 && media <= 10){
Console.WriteLine($"parabens voce foi aprovado");
}
}
public void verificaNota(){
if((prova1 <= 10 || prova2 <= 10 || trabalho <= 10) || (prova1 >= 0 || prova2 >= 0 || trabalho >= 0)){
Console.WriteLine("verificação bem sucedida");
}
else{
Console.WriteLine("nota invalida tente de novo");
}
}
class Program{
static void Main(){
Aluno w1 = new Aluno();
Console.WriteLine("digite sua matricula: ");
w1.matricula = int.Parse(Console.ReadLine());
Console.WriteLine("digite seu nome: ");
w1.nome = Console.ReadLine();
Console.WriteLine("digite a nota das provas 1 e 2 e do trabalho respectivamente");
w1.prova1 = int.Parse(Console.ReadLine());
w1.prova2 = int.Parse(Console.ReadLine());
w1.trabalho = int.Parse(Console.ReadLine());
w1.Media();
w1.final();
w1.verificaNota();

}
}
}