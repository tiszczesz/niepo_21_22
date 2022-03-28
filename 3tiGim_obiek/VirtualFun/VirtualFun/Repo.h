#pragma once
#include <vector>

#include "BaseClass.h"
#include "DerivedClassOne.h"
#include "DerivedClassTwo.h"
class Repo
{
public:
	static std::vector<BaseClass*> GetAll() {
		std::vector<BaseClass*> result;
		result.push_back(new DerivedClassOne());
		result.push_back(new DerivedClassTwo());
		return result;
	}
};

