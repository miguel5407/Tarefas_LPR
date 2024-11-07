#include <iostream>
#include <unordered_map>
#include <vector>
#include <string>
#include <numeric>  // for std::accumulate
#include <limits>   // for std::numeric_limits

int main() {
    // 1. Criação do Dicionário
    std::unordered_map<std::string, int> cidades = {
        {"CidadeA", 500000},
        {"CidadeB", 1200000},
        {"CidadeC", 750000},
        {"CidadeD", 300000},
        {"CidadeE", 950000}
    };

    // 2. Cálculo da Média de Populações
    double soma = 0;
    for (const auto& par : cidades) {
        soma += par.second;
    }
    double media = soma / cidades.size();

    // 3. Encontrar e Imprimir Cidades com Populações Acima da Média
    std::cout << "Cidades com população acima da média:" << std::endl;
    for (const auto& par : cidades) {
        if (par.second > media) {
            std::cout << par.first << std::endl;
        }
    }

    // 4. Encontrar e Imprimir a Cidade Mais Populosa e a Menos Populosa
    std::string cidadeMaisPopulosa;
    std::string cidadeMenosPopulosa;
    int maxPopulacao = std::numeric_limits<int>::min();
    int minPopulacao = std::numeric_limits<int>::max();

    for (const auto& par : cidades) {
        if (par.second > maxPopulacao) {
            maxPopulacao = par.second;
            cidadeMaisPopulosa = par.first;
        }
        if (par.second < minPopulacao) {
            minPopulacao = par.second;
            cidadeMenosPopulosa = par.first;
        }
    }

    std::cout << "Cidade mais populosa: " << cidadeMaisPopulosa << std::endl;
    std::cout << "Cidade menos populosa: " << cidadeMenosPopulosa << std::endl;

    // 5. Remover Cidades com População Igual a Y e Imprimir Dicionário Atualizado
    std::cout << "Digite a população que deseja remover: ";
    int populacaoParaRemover;
    std::cin >> populacaoParaRemover;

    std::vector<std::string> chavesParaRemover;
    for (const auto& par : cidades) {
        if (par.second == populacaoParaRemover) {
            chavesParaRemover.push_back(par.first);
        }
    }
    for (const auto& chave : chavesParaRemover) {
        cidades.erase(chave);
    }

    std::cout << "Dicionário atualizado:" << std::endl;
    for (const auto& par : cidades) {
        std::cout << par.first << ": " << par.second << std::endl;
    }

    return 0;
}
