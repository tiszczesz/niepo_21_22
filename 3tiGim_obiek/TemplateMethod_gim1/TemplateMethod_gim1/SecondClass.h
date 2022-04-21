#pragma once
#include "MyAbstractClass.h"
class SecondClass :
    public MyAbstractClass
{
	void RequiredOperations1() const {
		std::cout << "Logowanie do bazy szefa...\n";
	}
	void RequiredOperations2() const {
		std::cout << "Operacja obowiazkowa 2 z klasy Second...\n";
	}
	void Hook1() const {
		std::cout << "Operacja Hook1  z klasy Second...\n";
	}
	void Hook2() const {
		std::cout << "Usmiech dla szefa\n";
	}
};

