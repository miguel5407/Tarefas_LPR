#include <iostream>
using namespace std;
#include <string>
int main(){
    string cidades[] = {"vitoria", "belo-horizonte", "rio-de-janeiro","sao-paulo"};
    int numCidades = 4;
    int distancias[4][4]{
    {0,524,521,882},
    {524,0,434,586},
    {521,434,0,429},
    {882,586,429,0}
    };
    while(1){
    cout << "digite a cidade de origem: " << endl;
    string cidadeOrigem;
    cin >> cidadeOrigem;
    cout << "digite a cidade de destino: " << endl;
    string cidadeDestino;
    cin >>  cidadeDestino;
    //encontrando os indices da cidade na matriz
    int indiceOrigem = -1;
    int indiceDestino = -1;
    for(int i = 0; i < numCidades; i++){
    if(cidades[i] == cidadeOrigem){
       indiceOrigem = i;
    
    }
    if(cidades[i] == cidadeDestino){
        indiceDestino = i;
    }
    }
    if(indiceOrigem == -1 || indiceDestino == -1){
        cout << "uma ou ambas as cidades digitadas são invalidas tente novamente!!" << endl;
    }
    else{
       cout << "a distancia entre " << cidadeOrigem << " e " << cidadeDestino << " e de: " << distancias[indiceOrigem][indiceDestino] << "km" << endl;
    }
    return 0;
    }
}