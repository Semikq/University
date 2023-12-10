#include <iostream>
#include <Windows.h>
#include <math.h>
#include <string>
#include "AtmLibrary.h"

int main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	atm::Bankomat first;
	first.initID("93210"); // ініціалізація банкомата (first.ID)
	first.initMoney(65000); // ініціалізації суми грошей в банкоматі (first.moneyATM)
	first.display(); // виведення айді банкомата та суми грошей в банкоматі
	first.outMoney(600); // знімаємо гроші з банкомату (65000 - 600 = 64400)
	first.inMoney(100); // вводимо в банкомат 100 грн (64400 + 100 = 64500)
	first.outMoney(50); // намагаємося зняти <100грн - банкомат виведе помилку
	first.outMoney(435); // намагаємося зняти 435грн - банкомат виведе помилку
	first.display();

	return 0;
}
