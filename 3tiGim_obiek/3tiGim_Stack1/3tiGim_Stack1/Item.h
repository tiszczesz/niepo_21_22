#pragma once
#include <string>
#include <iostream>


class Item
{
private:
	std::string value;
	Item* previous;

public:
	Item();
	Item(std::string value, Item* item);
	std::string getValue() const {
		return value;
	}
	void setValue(std::string value) {
		this->value = value;
	}
	Item* getPrevious() {
		return previous;
	}
	void setPrevious(Item* previous) {
		this->previous = previous;
	}
	friend std::ostream& operator<<(std::ostream& os, const Item* item);
};


