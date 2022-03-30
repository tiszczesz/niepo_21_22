#pragma once
#include <vector>

#include "BaseClass.h"
#include "DerivedClassOne.h"
#include "DerivedClassTwo.h"
class Repo
{
private:
	std::vector<BaseClass*> data;
public:
	Repo() {
		data.push_back(new BaseClass());
		data.push_back(new DerivedClassOne());
		data.push_back(new DerivedClassOne());
		data.push_back(new DerivedClassTwo());
		data.push_back(new DerivedClassTwo());
	}
	 std::vector<BaseClass*>& GetAll() {		
		return data;
	}
	~Repo() {
		std::cout << "Czyszczenie data....\n";
		for (BaseClass* item : data) {
			delete item;
			item = nullptr;
		}
		data.clear();
	}
};

