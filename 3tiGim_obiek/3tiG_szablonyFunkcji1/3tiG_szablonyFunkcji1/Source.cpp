#include <iostream>
#include <string>
#include <ostream>
#include <exception>
using namespace std;



template<typename T> //szablon funkcji
T Add(T a, T b) {
	return a + b;
}

template<class T>
void Show(T data) {
	cout << data << endl;
}
template<typename T>
T Multiple(T a, T b) {
	return a * b;
}
// zdefiniowac strukture lub klase Point2D
struct Point2D {
	int x;
	int y;
	//przeciazyc operator+ dla tego typu
	//friend Point2D operator+(const Point2D& p1, const Point2D& p2);
	//friend ostream& operator<<(ostream& os, const Point2D& p);
};
Point2D operator+(const Point2D& p1, const Point2D& p2) {
	Point2D result;
	result.x = p1.x + p2.x;
	result.y = p1.y + p2.y;
	return result;
}
ostream& operator<<(ostream& os, const Point2D& p)
{
	os << "(" << p.x << "," << p.y << ")";
	return os;
}
int main() {
	cout << Add<int>(3, 8) << endl; //wersja dla liczb calkowitych
	cout << Add<string>("Ala", "Ola") << endl;
	cout << Multiple<double>(3.0, 5) << endl;
	Point2D p1{12,7};
	Point2D p2{4,8};
	try {
		
	}()
	Point2D p3{ 4, 8 };
	Point2D wynik = Add<Point2D>(p1, p2);
	cout << "wynik.x = " << wynik.x << " wynik.y = " << wynik.y << endl;
	cout << p1 << " + " << p2 <<" + "<<p3<< " = " << Add<Point2D>(Add<Point2D>(p1, p2),p3) << endl;
	cout << p1 << " + " << p2 <<" + "<<p3<< " = " << p1+(p2+p3) << endl;
	//cout << Multiple<string>("3.0", "5") << endl; // brak mnozenia dla stringa
	Show<string>("Ala ma kota");
	return 0;
}