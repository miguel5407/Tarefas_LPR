#include <iostream>
using namespace std;
int main()
{
    int numeros[10];
    cout << "digite 10 numeros inteiros: " << endl;
    int tamanho = sizeof(numeros) / sizeof(numeros[0]);
    for(int i = 0; i < tamanho; i++){
    cin >> numeros[i];
    }
    cout << "qual numero voce deseja pesquisar? " << endl;
    int pesquisa;
    cin >> pesquisa;
    int posicao[10];
    int cont = 0;
    for(int i = 0; i < tamanho; i++){
    if(numeros[i] == pesquisa){
        posicao[cont] = i;
        cont++;
    }
    }
    if(cont > 0){
        cout << "o numero " << pesquisa << " foi encontrado " << cont << " vezes nas seguintes posiçoes" << endl;
        for(int i = 0; i < cont; i++){
        cout << "posicao: " << posicao[i];
        }
    }
    else{
    cout << "o numero nao foi encontrado no vetor" << endl;    
    }
} 