#pragma once
#include "BaseClass.h"
class DerivedClassOne :    public BaseClass
{
public:
	DerivedClassOne() {  }
	void ToOverride() {
		std::cout << "Nadpisana w klasie DerivedClassOne.." << std::endl;
	}
};

