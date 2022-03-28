#pragma once
#include "MainClass.h"
class DerivedTwoClass : public MainClass
{
private:
	bool isOK  { true };
public:
	DerivedTwoClass() {  }
	DerivedTwoClass(bool isOK,std::string stringVal):MainClass(stringVal) {
		this->isOK = isOK;
	}
	void ToOverride() {
		std::cout << "Metoda z klasy DerviedTwoClass...." << std::endl;
	}
};

