#include "pch.h"
#include "AtmLibrary.h"

#include <iostream>
#include <Windows.h>
#include <math.h>
#include <string>
#include <stdexcept>

namespace atm {
	// ������������
	Bankomat::Bankomat() :
		ID("nameless"), moneyATM(0) {}
	Bankomat::Bankomat(std::string id) :
		ID(id), moneyATM(0) {}
	Bankomat::Bankomat(int money) :
		ID("nameless"), moneyATM(money) {}
	Bankomat::Bankomat(std::string id, int money) :
		ID(id), moneyATM(money) {}

	// ���������
	bool Bankomat::operator==(Bankomat arg) { return (moneyATM == arg.moneyATM); }
	bool Bankomat::operator!=(Bankomat arg) { return (moneyATM != arg.moneyATM); }
	bool Bankomat::operator>=(Bankomat arg) { return (moneyATM >= arg.moneyATM); }
	bool Bankomat::operator<=(Bankomat arg) { return (moneyATM <= arg.moneyATM); }
	bool Bankomat::operator>(Bankomat arg) { return (moneyATM > arg.moneyATM); }
	bool Bankomat::operator<(Bankomat arg) { return (moneyATM < arg.moneyATM); }

	// ����� ������������ ����� � ��������
	void Bankomat::inMoney(int money) {
		if (money >= 0) {
			moneyATM += money;
			std::cout << money << " ��� ���� ���i��� �������!" << std::endl;
		}
		else
			std::cout << "�������! �i������ ������� ������ � �������� �� ���� ���� ����� 0!" << std::endl;
	}
	// ����� ������ ����� ���� ������
	void Bankomat::outMoney(int money) {
		int out = money;
		// ����� ������ �����
		if (money >= minUser && money <= maxUser) {
			// ���� ��� �������� ��������� ������ ������
			for (int i = 0; i < std::size(arr); i++) {
				if (money >= arr[i]) {
					money -= arr[i];
					if (money >= arr[i]) {
						i--;
					}
				}
			}
			// �� ����� ���������� ����� ����������, �� ������� ������� �����
			if (money < 10 && money != 0) {
				std::cout << "�������! ����i�� ����, ������ " <<
					"10, 20, 50, 100, 200, 500, 1000!" << std::endl;
			}
			else if (money == 0) {
				moneyATM -= out; // ��� ���������, � ��������� ���������� �����
				std::cout << out << " ��� ���� ���i��� ��������!" << std::endl;
			}
		}
		else {
			if (money > maxUser)
				std::cout << "�������! ��������� ������� �� ���� ��� �i���� 2000 ���!\n";
			else if (money < minUser)
				std::cout << "�������! ��������� ������� �� ���� ��� ����� 100 ���!\n";
		}
	}

	// ����� ������������ ���������
	void Bankomat::initID(std::string id) { ID = id; }
	// ����� ������������ ���� ������ � ��������
	void Bankomat::initMoney(int money) { moneyATM = money; }
	// ����� ������������ ����� �������
	void Bankomat::read() {
		std::cout << "����i�� ���i ���������: ";
		std::cin >> ID;
		std::cout << "����i�� �i������ ������ � ��������i: ";
		std::cin >> moneyATM;
	}
	// ����� ��������� ID �� ���� ������ � ��������
	void Bankomat::display() {
		std::cout << "ID of ATM: " << ID << std::endl;
		std::cout << "SUMM OF MONEY: " << moneyATM << std::endl;
	}
}
