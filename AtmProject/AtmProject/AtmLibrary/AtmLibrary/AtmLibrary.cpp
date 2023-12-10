#include "pch.h"
#include "AtmLibrary.h"

#include <iostream>
#include <Windows.h>
#include <math.h>
#include <string>
#include <stdexcept>

namespace atm {
	// конструктори
	Bankomat::Bankomat() :
		ID("nameless"), moneyATM(0) {}
	Bankomat::Bankomat(std::string id) :
		ID(id), moneyATM(0) {}
	Bankomat::Bankomat(int money) :
		ID("nameless"), moneyATM(money) {}
	Bankomat::Bankomat(std::string id, int money) :
		ID(id), moneyATM(money) {}

	// оператори
	bool Bankomat::operator==(Bankomat arg) { return (moneyATM == arg.moneyATM); }
	bool Bankomat::operator!=(Bankomat arg) { return (moneyATM != arg.moneyATM); }
	bool Bankomat::operator>=(Bankomat arg) { return (moneyATM >= arg.moneyATM); }
	bool Bankomat::operator<=(Bankomat arg) { return (moneyATM <= arg.moneyATM); }
	bool Bankomat::operator>(Bankomat arg) { return (moneyATM > arg.moneyATM); }
	bool Bankomat::operator<(Bankomat arg) { return (moneyATM < arg.moneyATM); }

	// метод завантаження купюр у банкомат
	void Bankomat::inMoney(int money) {
		if (money >= 0) {
			moneyATM += money;
			std::cout << money << " грн було успiшно введені!" << std::endl;
		}
		else
			std::cout << "Помилка! Кiлькість вхідних грошей в банкомат не може бути менше 0!" << std::endl;
	}
	// метод зняття певної суми грошей
	void Bankomat::outMoney(int money) {
		int out = money;
		// умова видачі купюр
		if (money >= minUser && money <= maxUser) {
			// цикл для перевірки можливості зняття грошей
			for (int i = 0; i < std::size(arr); i++) {
				if (money >= arr[i]) {
					money -= arr[i];
					if (money >= arr[i]) {
						i--;
					}
				}
			}
			// на основі результату циклу перевіряємо, чи можливо вивести гроші
			if (money < 10 && money != 0) {
				std::cout << "Помилка! Введiть суму, кратну " <<
					"10, 20, 50, 100, 200, 500, 1000!" << std::endl;
			}
			else if (money == 0) {
				moneyATM -= out; // при виведенні, з банкомата знімаються гроші
				std::cout << out << " грн були успiшно виведені!" << std::endl;
			}
		}
		else {
			if (money > maxUser)
				std::cout << "Помилка! Неможливо вивести за один раз бiльше 2000 грн!\n";
			else if (money < minUser)
				std::cout << "Помилка! Неможливо вивести за один раз менше 100 грн!\n";
		}
	}

	// метод ініціалізації банкомата
	void Bankomat::initID(std::string id) { ID = id; }
	// метод ініціалізації суми грошей в банкоматі
	void Bankomat::initMoney(int money) { moneyATM = money; }
	// метод ініціалізації через консоль
	void Bankomat::read() {
		std::cout << "Введiть айдi банкомата: ";
		std::cin >> ID;
		std::cout << "Введiть кiлькість грошей в банкоматi: ";
		std::cin >> moneyATM;
	}
	// метод виведення ID та суми грошей в банкоматі
	void Bankomat::display() {
		std::cout << "ID of ATM: " << ID << std::endl;
		std::cout << "SUMM OF MONEY: " << moneyATM << std::endl;
	}
}
