#include <iostream>
#include <string>
#include <cstdlib>
#include "Item.h"
#include "Stack.h"


using namespace std;

int main() {
	/*Item* i1 = new Item();
	cout << i1;
	Item* i2 = new Item("nowy element", i1);
	cout << i2;

	delete i1;
	delete i2;
	i1 = nullptr;
	i2 = nullptr;*/
	Stack s1;
	s1.Push(new Item("pierwszy", nullptr));
	s1.Push(new Item("drugi", nullptr));
	s1.Push(new Item("trzeci", nullptr));
	s1.Push(new Item("czwarty", nullptr));
	cout << s1;
	cout << "Zdejmowanie ze stosu...." << endl;
	Item* pobrany = s1.Pop();
	cout << pobrany << "to element ze zstosu"<< endl;
	cout << " =====================================\n";
	
	cout << s1;
	delete pobrany;
	pobrany = nullptr;
	return 0;
}