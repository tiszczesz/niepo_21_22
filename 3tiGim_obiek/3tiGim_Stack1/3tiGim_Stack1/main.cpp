#include <iostream>
#include <string>
#include <cstdlib>
#include "Item.h"
#include "Stack.h"
#include <vector>

using namespace std;
void Cw1();
void Cw2();
class My{};
int main() {
	/*Item* i1 = new Item();
	cout << i1;
	Item* i2 = new Item("nowy element", i1);
	cout << i2;

	delete i1;
	delete i2;
	i1 = nullptr;
	i2 = nullptr;*/
	//Cw1();
	//Cw2();
	My m1;
	My m2;
	//cout << m1 + m2 << endl;
	cout << 3.0 / 2 << endl;
	int a[] = { 12,4,6,7,80,8 };
	cout << a[5] << endl;
	cout << 4 + 6 << endl;
	string w1 = "ala";
	string w2 = "bela";
	cout << w1 + w2 << endl;
	//cout << w1 * w2 << endl;
	vector<double> dane{ 3,5,8,9.0 };
	dane.push_back(1222);
	for (double s : dane) {
		cout << s << " ";
	}
	cout << dane.size() <<endl;
	return 0;
}
void Cw2() {
	vector<string> imiona{ "Anna","Monika","Tomasz","Gerwazy","Urszula" };
	vector<string> reversImiona;
	//utworzyc stos z imionami
	//drugi wektor imiona osttni jako pierwszy
	Stack s1;
	for (string imie : imiona) {
		s1.Push(new Item(imie,nullptr));
	}
	
	cout << s1;
	Item* it = nullptr;
	while(s1.GetTop()!=nullptr) {
		it = s1.Pop();
		reversImiona.push_back(it->getValue());
		delete it;
	}
	cout << " ------------------ wektor imion revers ----------------\n";
	for (string imie : reversImiona) {
		cout << imie << endl;
	}
}
void Cw1() {
	Stack s1;
	s1.Push(new Item("pierwszy", nullptr));
	s1.Push(new Item("drugi", nullptr));
	s1.Push(new Item("trzeci", nullptr));
	s1.Push(new Item("czwarty", nullptr));
	cout << s1;
	cout << "Zdejmowanie ze stosu...." << endl;
	Item* pobrany = s1.Pop();
	cout << pobrany << "to element ze stosu" << endl;
	cout << " =====================================\n";

	cout << s1;
	delete pobrany;
	pobrany = nullptr;
}