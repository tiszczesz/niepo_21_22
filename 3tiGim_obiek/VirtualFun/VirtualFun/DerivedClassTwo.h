#pragma once
#include "BaseClass.h"
class DerivedClassTwo : public BaseClass
{
public:
	DerivedClassTwo() {  }
	void ToOverride() {
		std::cout << "Nadpisana w klasie DerivedClassTwo.." << std::endl;
	}
};

