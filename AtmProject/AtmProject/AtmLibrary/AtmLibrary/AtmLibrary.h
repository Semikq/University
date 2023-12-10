#pragma once

#ifdef MATHFUNCSDLL_EXPORTS
#define MATHFUNCSDLL_API __declspec(dllexport)
#else
#define MATHFUNCSDLL_API __declspec(dllimport)
#endif

#include <string>

namespace atm {
	// об'явлення класу Bankomat
	class Bankomat {
	private:
		std::string ID;	// ID банкомата
		int moneyATM; // сума грошей в банкоматі
		const int minUser = 100, maxUser = 2000;
		const int arr[7]{ 1000, 500, 200, 100, 50, 20, 10 };

	public:
		// конструктори
		MATHFUNCSDLL_API Bankomat();
		MATHFUNCSDLL_API Bankomat(std::string id);
		MATHFUNCSDLL_API Bankomat(int money);
		MATHFUNCSDLL_API Bankomat(std::string id, int money);

		// оператори
		MATHFUNCSDLL_API bool operator==(Bankomat arg);
		MATHFUNCSDLL_API bool operator!=(Bankomat arg);
		MATHFUNCSDLL_API bool operator>=(Bankomat arg);
		MATHFUNCSDLL_API bool operator<=(Bankomat arg);
		MATHFUNCSDLL_API bool operator>(Bankomat arg);
		MATHFUNCSDLL_API bool operator<(Bankomat arg);

		MATHFUNCSDLL_API void inMoney(int money); // метод завантаження купюр у банкомат
		MATHFUNCSDLL_API void outMoney(int money); // метод зняття певної суми грошей

		MATHFUNCSDLL_API void initID(std::string id);	// метод ініціалізації банкомата
		MATHFUNCSDLL_API void initMoney(int money);	// метод ініціалізації суми грошей в банкоматі
		MATHFUNCSDLL_API void read(); // метод ініціалізації через консоль
		MATHFUNCSDLL_API void display(); // метод виведення ID та суми грошей в банкоматі
	};
}
