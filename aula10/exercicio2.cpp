#include <iostream>
#include <vector>
#include <algorithm>
#include <ctime>

using namespace std;

void gerarNumerosAleatorios(vector<int>& numeros, int quantidade) {
    srand(time(0));
    for (int i = 0; i < quantidade; i++) {
        numeros.push_back(rand() % 100);
    }
}

void imprimirLista(const vector<int>& lista) {
    for (int num : lista) {
        cout << num << " ";
    }
    cout << endl;
}

void removerPares(vector<int>& lista) {
    lista.erase(remove_if(lista.begin(), lista.end(), [](int num) { return num % 2 == 0; }), lista.end());
}

void imprimirNumerosRepetidos(const vector<int>& lista) {
    vector<int> duplicados;
    for (size_t i = 1; i < lista.size(); i++) {
        if (lista[i] == lista[i - 1]) {
            if (find(duplicados.begin(), duplicados.end(), lista[i]) == duplicados.end()) {
                duplicados.push_back(lista[i]);
            }
        }
    }
    if (duplicados.empty()) {
        cout << "Não existem números repetidos." << endl;
    } else {
        cout << "Números repetidos: ";
        for (int num : duplicados) {
            cout << num << " ";
        }
        cout << endl;
    }
}

int main() {
    vector<int> numeros;
    gerarNumerosAleatorios(numeros, 100);

    cout << "Lista original:" << endl;
    imprimirLista(numeros);

    sort(numeros.begin(), numeros.end());
    cout << "Lista ordenada:" << endl;
    imprimirLista(numeros);

    removerPares(numeros);
    cout << "Lista sem os pares:" << endl;
    imprimirLista(numeros);

    imprimirNumerosRepetidos(numeros);

    return 0;
}