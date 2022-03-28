#pragma once
#include "MainClass.h"
#include <string>
class DerivedOneClass :    public MainClass
{
private:
	int value{ 99 };
public:
	DerivedOneClass() { value= { 99 }; }
	DerivedOneClass(int intVal,std::string stringVal):MainClass(stringVal),value(intVal) {	}
	void ToOverride() {
		std::cout << "Metoda z klasy DerviedOneClass...." << std::endl;
	}
};

