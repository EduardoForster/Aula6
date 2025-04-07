#include <iostream>


int osrever(int num) {
    int reverso = 0;
    while (num != 0) {
        int digit = num % 10; 
        reverso = reverso * 10 + digit; 
        num /= 10; 
    }
    return reverso;
}

int main() {
    int number;
    std::cout << "Digite um numero inteiro: ";
    std::cin >> number;

    int revertido = osrever (number);
    std::cout << "O reverso do numero vai ser: " << revertido << std::endl;

    return 0;
}