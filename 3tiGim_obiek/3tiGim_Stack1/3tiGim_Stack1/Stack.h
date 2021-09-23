#pragma once
#include "Item.h"
class Stack
{
private:
	int count = { 0 };
	Item* top = { nullptr };
public:
	int GetCount() const {
		return count;
	}
	Item* GetTop() const {
		return top;
	}
	void SetTop(Item* item) {
		top = item;
	}
	friend std::ostream& operator<<(std::ostream& os, const Stack& stack);
	Stack();
	bool Push(Item* item);
	Item* Pop();
	~Stack();
};

