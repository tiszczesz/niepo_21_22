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
	Item(std::string value, Item* previous);
	~Item();
	friend std::ostream& operator<<(std::ostream& os, const Item& item);
	Item* getPrevious() {
		return previous;
	}
	void setPrevious(Item* item) {
		previous = item;
	}
};

