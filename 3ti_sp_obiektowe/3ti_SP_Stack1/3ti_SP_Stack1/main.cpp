#include <iostream>
#include <cstdlib>
#include "Stack.h"
using namespace std;

int main() {

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
	return 0;
}