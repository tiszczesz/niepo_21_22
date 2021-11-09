#include <iostream>
#include <ostream>
#include <string>
using namespace std;
template<class T>
T Add(T a,T b) {
	return a + b;
}

string wynik = Add<string>("ala", "mala");
double wynik2 = Add<double>(12.5, 8);
int main() {
	cout << wynik << endl;
	cout << wynik << endl;
	if("Ala" > "Mala") {
		std::cout << "OK" << std::endl;
	}else {
		std::cout << "NO OK" << std::endl;
	}
	return 0;
}
