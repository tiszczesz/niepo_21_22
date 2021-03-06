#pragma once
#include "Item.h"

class Stack
{
private:
	int count{ 0 };
	Item* head{ nullptr };
public:
	bool Push(Item& item);
	Item* Pop();
	Stack();
	~Stack();
	friend std::ostream& operator<<(std::ostream& os, const Stack& stack);
	int getCount() const {
		return count;
	}
	Item* GetHead() {
		return head;
	}
};

