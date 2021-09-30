#include <iostream>
#include <string>
#include <cstdlib>
#include "Item.h"
#include "Stack.h"
#include <vector>

using namespace std;
void Cw1();
void Cw2();
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
	Cw2();
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
	for (string imie : reversImiona) {
		
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