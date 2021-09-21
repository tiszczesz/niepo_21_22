#include <iostream>
#include <cstdlib>
#include "Stack.h"
#include <vector>
using namespace std;
void cw1();
void cw0();
int main() {
	//cw0();
	cw1();
	return 0;
}
void cw0() {
	Stack s1;
	Item* i1 = new Item("item 1", nullptr);
	Item* i2 = new Item("item 2", nullptr);
	Item* i3 = new Item("item 3", nullptr);
	Item* i4 = new Item("item 4", nullptr);
	s1.Push(*i1);
	s1.Push(*i2);
	s1.Push(*i3);
	s1.Push(*i4);
	cout << s1;
	Item* droped = s1.Pop();
	cout << " zdjecie ostatniego....." << endl;
	cout << (*droped) << endl;
	cout << s1;
	cw1();
}
void cw1() {
	vector<string> wyrazy{ "Ala","ma","kota" };
	vector<string> odwrocone;
	Stack s2;
	for (string wyraz : wyrazy) {
		Item* ii = new Item(wyraz, nullptr);
		s2.Push(*ii);		
	}
	cout << s2;
	//todo
}