#pragma once
#include <vector>
#include "DerivedOneClass.h"
#include "DerivedThreeClass.h"
#include "DerivedTwoClass.h"

class Repo
{
private:
	std::vector<MainClass*> items;

public:
	
	Repo() {
		//items.push_back(new MainClass());
		items.push_back(new DerivedOneClass());
		items.push_back(new DerivedThreeClass());
		items.push_back(new DerivedOneClass(34, "blblblb"));
		items.push_back(new DerivedTwoClass());
		items.push_back(new DerivedTwoClass(false, "gggg"));
		items.push_back(new DerivedThreeClass());
	}
	 std::vector<MainClass*>& GetItems() {
		return items;
	}
	~Repo() {
		std::cout << "czyszczenie....." << std::endl;
		for (auto item : items) {
			delete item;
			item = nullptr;
		}
		items.clear();
	}
};

