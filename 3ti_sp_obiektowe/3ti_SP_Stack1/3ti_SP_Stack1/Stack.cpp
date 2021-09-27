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
	Item* temp = head;
	
	while(temp!=nullptr) {
		Item* next = temp->getPrevious();
		delete temp;
		temp = next;
	}
	std::cout << "Niszczenie stosu...." << std::endl;
}
bool Stack::Push(Item& item) {
	count++;
	item.setPrevious(head);
	head = &item;
	return true;
}
Item* Stack::Pop() {
	if (head == nullptr) return nullptr;
	Item* temp = head;
	//zmiana heada na wczesniejszy element
	head = head->getPrevious();
	//pobranie ostatniego elementu
	//count--
	count--;
	return temp;
}




