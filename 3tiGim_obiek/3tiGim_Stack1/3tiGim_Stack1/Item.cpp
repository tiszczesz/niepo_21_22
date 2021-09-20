#include "Item.h"

Item::Item() {
	value =  "";
	previous = nullptr;
}
Item::Item(std::string value,Item* item) {
	setValue(value);
	setPrevious(item);
}
std::ostream& operator<<(std::ostream& os, const Item* item) {
	os << "Inforamcja o elemencie stosu: wartosc: " << item->getValue() << std::endl;
	return os;
}

