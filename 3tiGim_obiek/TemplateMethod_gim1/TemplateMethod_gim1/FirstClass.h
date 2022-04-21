#pragma once
#include "MyAbstractClass.h"
class FirstClass :    public MyAbstractClass
{
	void RequiredOperations1() const {
		std::cout << "Operacja obowiazkowa 1 z klasy First...\n";
	}
	void RequiredOperations2() const {
		std::cout << "Operacja obowiazkowa 2 z klasy First...\n";
	}
	void Hook1() const {
		std::cout << "Operacja Hook1  z klasy First...\n";
	}
};

