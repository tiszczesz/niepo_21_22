#include "Stack.h"

Stack::Stack() {
	count = 0;
	top = nullptr;
}
bool Stack::Push(Item* item) {
	if (item == nullptr) return false;
	count++;
	item->setPrevious(top);
	top = item;
	return true;
}

Stack::~Stack() {
	if(count!=0) {
		Item* item = top;
		Item* temp = nullptr;
		while (item!=nullptr) {
			temp = item;
			item = item->getPrevious();
			delete temp;
		}
		count = 0;
		top = nullptr;
	}
}

std::ostream& operator<<(std::ostream& os, const Stack& stack) {
	if (stack.GetCount() == 0) {
		os << "Stos jest pusty!!!" << std::endl;
		return os;
	}
	os << "Informocje o stosie: rozmiar: " << stack.GetCount() << std::endl;
	Item* temp = stack.GetTop();
	while (temp!=nullptr) {
		os << temp;
		temp = temp->getPrevious();//  (*temp).getPrevious();
	}
	return os;	
}
Item* Stack::Pop() {
	Item* item = top;
	top = item->getPrevious();
	count--;
	return item;
}


