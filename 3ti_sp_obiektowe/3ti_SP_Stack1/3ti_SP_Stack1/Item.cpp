#include "Item.h"

std::ostream& operator<<(std::ostream& os, const Item& item) {
	os << "Wartosc: " << item.value << std::endl;
	return os;
}
Item::Item() {
	value = "";
	previous = nullptr;
}
Item::Item(std::string value, Item* previous) {
	this->value = value;
	this->previous = previous;
}
Item::~Item() {
	value = "";
	previous = nullptr;
}



