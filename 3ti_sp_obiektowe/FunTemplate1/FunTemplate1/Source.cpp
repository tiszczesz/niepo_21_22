#include <iostream>
#include <string>
using namespace std;
int Add(int a, int b) {
	return a + b;
}
double Add(double a, double b) {
	return a + b;
}
template<typename  T> //definicja szablonu funkcji dla typu jakiegos T
T AddTemp(T a, T b) {
	return a + b;
} //dla mnozenia
template<typename  T> //definicja szablonu funkcji dla typu jakiegos T
T TimesTemp(T a, T b) {
	return a * b;
} //dla mnozenia

int main() {
	cout << " Calkowite: " << Add(4, 7) << endl;
	cout << " Double: " << Add(4.7, 7.2) << endl;
	cout << AddTemp<int>(12, 5) << endl; //implementacja szablonu dla int
	cout << AddTemp<double>(12.8, 5) << endl; //implementacja szablonu dla double
	cout << AddTemp<char>('a', 'n') << endl;
	cout << AddTemp<string>("ala", "bella") << endl;
	cout << AddTemp<bool>(false, false) << endl;
	cout << TimesTemp<double>(12, 44) << endl;
	cout << TimesTemp<string>("12", "44") << endl;//brak mozliwosci mnozenia dla string
	
	
	//cout << (5.0/10) << endl;
	return 0;
}