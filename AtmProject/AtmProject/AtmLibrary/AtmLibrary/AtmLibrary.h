#pragma once

#ifdef MATHFUNCSDLL_EXPORTS
#define MATHFUNCSDLL_API __declspec(dllexport)
#else
#define MATHFUNCSDLL_API __declspec(dllimport)
#endif

#include <string>

namespace atm {
	// ��'������� ����� Bankomat
	class Bankomat {
	private:
		std::string ID;	// ID ���������
		int moneyATM; // ���� ������ � ��������
		const int minUser = 100, maxUser = 2000;
		const int arr[7]{ 1000, 500, 200, 100, 50, 20, 10 };

	public:
		// ������������
		MATHFUNCSDLL_API Bankomat();
		MATHFUNCSDLL_API Bankomat(std::string id);
		MATHFUNCSDLL_API Bankomat(int money);
		MATHFUNCSDLL_API Bankomat(std::string id, int money);

		// ���������
		MATHFUNCSDLL_API bool operator==(Bankomat arg);
		MATHFUNCSDLL_API bool operator!=(Bankomat arg);
		MATHFUNCSDLL_API bool operator>=(Bankomat arg);
		MATHFUNCSDLL_API bool operator<=(Bankomat arg);
		MATHFUNCSDLL_API bool operator>(Bankomat arg);
		MATHFUNCSDLL_API bool operator<(Bankomat arg);

		MATHFUNCSDLL_API void inMoney(int money); // ����� ������������ ����� � ��������
		MATHFUNCSDLL_API void outMoney(int money); // ����� ������ ����� ���� ������

		MATHFUNCSDLL_API void initID(std::string id);	// ����� ������������ ���������
		MATHFUNCSDLL_API void initMoney(int money);	// ����� ������������ ���� ������ � ��������
		MATHFUNCSDLL_API void read(); // ����� ������������ ����� �������
		MATHFUNCSDLL_API void display(); // ����� ��������� ID �� ���� ������ � ��������
	};
}
