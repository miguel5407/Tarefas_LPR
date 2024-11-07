using System;
public class Estagio{
public string Nome{
get;
set;    
}
public string DiaOuNoite{
get;
set;    
}
public string Pais{
get;
set;
}
public int Nivel{
get;
set;    
}
public Estagio(string nome, string diaOuNoite, string pais, int nivel){
Nome = nome;
DiaOuNoite = diaOuNoite;
Pais = pais;
Nivel = nivel;
}
}
public class Habilidade{
public string Nome{
get;
set;    
}   
public int Dano{
get;
set;    
} 
public int ExpNecessaria{
get;
set;    
}
public Habilidade(string nome, int dano, int expNecessaria){
Nome = nome;
Dano = dano;
ExpNecessaria = expNecessaria;
}
}
public void Explorar(){
Console.WriteLine($"explorando o estagio {Nome}");    
}
public void VerificarTempo(){
Console.WriteLine($"verificando se é dia ou noite em {Nome}: {DiaOuNoite}");    
}
public class Personagem{
public string Nome{
get;
set;    
}
public string Especie{
get;
set;    
}
public string CordePele{
get;
set;    
}
public int Vida{
get;
set;    
}
public Personagem(string nome, string especie, string corDePele, int vida){
Nome = nome;
Especie = especie;
CordePele = corDePele;
Vida = vida;
}
public void Atacar(){
Console.WriteLine($"{Nome} ataca!!!");
} 
public void UsarHabilidade(Habilidade habilidade){
Console.WriteLine($"o {Nome} usa a habilidade {habilidade.Nome} causando {habilidade.Dano} de dano");    
}   
}
class Program{
static void Main(){
Habilidade p1 = new Habilidade("soco", 50, 200);
Personagem j1 = new Personagem("sonic", "ouriço", "azul", 900);
Estagio l1 = new Estagio("dragon road", "dia", "china", 7);
Console.WriteLine($"personagem {j1. Nome} da espécie: {j1.Especie}, da cor: {j1.CorDePele} e de  vida: {j1.Vida}");
j1.Atacar();
j1.UsarHabilidade();
j1.Explorar;
j1.VerificarTempo();
}    
}