using System;

class Program{

static void Main(){
    Console.WriteLine("escolha uma classe de personagem");
    Console.WriteLine("1.Guerreira");
    Console.WriteLine("2.Mago");
    Console.WriteLine("3.Arqueira");
    int escolha;
    escolha = int.Parse(Console.ReadLine());
    switch(escolha){
        case 1: 
        Console.WriteLine("classe guerreira foi escolhida");
        Console.WriteLine("habilidades: ataque pesado e defesa total");
        break;
        case 2:
        Console.WriteLine("classe mago foi escolhida");
        Console.WriteLine("habilidades: bola de fogo e escudo de gelo");
        break;
        case 3:
        Console.WriteLine("classe arqueira foi escolhida");
        Console.WriteLine("habilidades: flecha precisa e disparo triplo");
        break;
        default:
        Console.WriteLine("opção invalida");
        break;
        
    }

    
}
}