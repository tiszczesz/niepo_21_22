#pragma once
#include "BaseClass.h"
class DerivedClassOne :    public BaseClass
{
private:
	bool isOK = false;
public:
	DerivedClassOne() {  }
	DerivedClassOne(int fromBase,bool isOk):BaseClass(fromBase) {
		this->isOK = isOk;
	}
	void ToOverride() {
		std::cout << "Nadpisana w klasie DerivedClassOne.." << std::endl;
	}
};

