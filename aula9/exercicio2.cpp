#include <iostream>
#include <string>
using namespace std;
    struct Livro{
    string titulo;
    string autor;
    int anoPublicacao;
    int NumeroPaginas;
    float Preco;
    };
int main(){
    Livro a1;
    cout << "titulo do primeiro livro: ";
    cin >> a1.titulo;
    cout << "autor do primeiro livro: ";
    cin >> a1.autor;
    cout << "ano de publicação do primeiro livro: ";
    cin >> a1.anoPublicacao;
    cout << "numero de paginas do primeiro livro: ";
    cin >> a1.NumeroPaginas;
    cout << "preço do primeiro livro:";
    cin >> a1.Preco;
    Livro a2;
    cout << "titulo do segundo livro: ";
    cin >> a2.titulo;
    cout << "autor do segundo livro: ";
    cin >> a2.autor;
    cout << "ano de publicação do segundo livro: ";
    cin >> a2.anoPublicacao;
    cout << "numero de paginas do segundo livro: ";
    cin >> a2.NumeroPaginas;
    cout << "preço do segundo livro: ";
    cin >> a2.Preco;
    Livro a3;
    cout << "titulo do terceiro livro: ";
    cin >> a3.titulo;
    cout << "autor do terceiro livro: ";
    cin >> a3.autor;
    cout << "ano de publicação do terceiro livro: ";
    cin >> a3.anoPublicacao;
    cout << "numero de paginas do terceiro livro: ";
    cin >> a3.NumeroPaginas;
    cout << "preço do terceiro livro: ";
    cin >> a3.Preco;
    float precoTotal = a1.Preco + a2.Preco + a3.Preco;
    float mediaPaginas = (a1.NumeroPaginas + a2.NumeroPaginas + a3.NumeroPaginas) / 3;
    cout << "o preço total é: " << precoTotal << "  e a média de paginas é: " << mediaPaginas;
}