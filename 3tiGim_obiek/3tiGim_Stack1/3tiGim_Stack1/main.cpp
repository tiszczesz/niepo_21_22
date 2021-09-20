#include <iostream>
#include <string>
#include <cstdlib>
#include "Item.h"


using namespace std;

int main() {
	Item* i1 = new Item();
	cout << i1;
	Item* i2 = new Item("nowy element", i1);
	cout << i2;

	delete i1;
	delete i2;
	i1 = nullptr;
	i2 = nullptr;
	return 0;
}