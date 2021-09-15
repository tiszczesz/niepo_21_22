#include "Stack.h"

std::ostream& operator<<(std::ostream& os, const Stack& stack) {
	os << "Informacje o stosie: ilosc elementow: " << stack.getCount()<<std::endl;
	if(stack.getCount()>0) {
		Item* current = stack.head;
		do {
			os << (*current);
			current = current->getPrevious();
		} while (current != nullptr);
	}
	return os;
}
Stack::Stack() {
	head = nullptr;
	count = 0;
}
Stack::~Stack() {
	std::cout << "Niszczenie stosu...." << std::endl;
}
bool Stack::Push(Item& item) {
	count++;
	item.setPrevious(head);
	head = &item;
	return true;
}




