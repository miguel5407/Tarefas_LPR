using System;
using System.Collections.Generic;
class Program{
static void Main(){
Dictionary <string,int> pessoas = new Dictionary <string,int>();
Console.WriteLine("digite quantas pessoas deseja inserir");
int quantPessoas = int.Parse(Console.ReadLine());
for(int i = 0; i < quantPessoas; i++){
Console.WriteLine($"digite o nome da pessoa {i + 1}");
string nome = Console.ReadLine();
Console.WriteLine($"digite a idade de {nome}");
int idade = int.Parse(Console.ReadLine());
pessoas[nome] = idade;
}
int somaIdades = 0;
foreach(var pessoa in pessoas){
somaIdades += pessoa.Value;
}
double media = (double) somaIdades / quantPessoas;
Console.WriteLine("pessoas com idade acima da média: ");
foreach(var pessoa in pessoas){
if(pessoa.Value > media){
Console.WriteLine(pessoa.Key);
}
}
string acharVelho = null;
string acharNovo = null;
int idadeMaisVelho = 0;
int idadeMaisNovo = 999;
foreach(var pessoa in pessoas){
if(pessoa.Value > idadeMaisVelho){
idadeMaisVelho = pessoa.Value;
acharVelho = pessoa.Key;
}
if(pessoa.Value < idadeMaisNovo){
idadeMaisNovo = pessoa.Value;
acharNovo = pessoa.Key;
}
}
Console.WriteLine($"pessoa mais velha: {acharVelho} com {idadeMaisVelho} anos");
Console.WriteLine($"pessoa mais nova: {acharNovo} com {idadeMaisNovo} anos");
Console.WriteLine("digite a idade que deseja remover");
int idadeRemove = int.Parse(Console.ReadLine());
List <string> chavesRemove = new List <string>();
foreach(var pessoa in pessoas){
if(pessoa.Value == idadeRemove){
chavesRemove.Add(pessoa.Key);
}
}
foreach(var chave in chavesRemove){
pessoas.Remove(chave);
}
Console.WriteLine("dicionario atualizado!");
foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Key}: {pessoa.Value} anos");
        }
}
}