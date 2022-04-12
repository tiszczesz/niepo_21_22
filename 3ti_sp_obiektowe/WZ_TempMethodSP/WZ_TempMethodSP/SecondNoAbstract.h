#pragma once
#include <iostream>

#include "MyAbstract.h"

class SecondNoAbstract : public MyAbstract
{
protected:
	void RequiredOperation1()const {
		std::cout << "Opeacja z klasy secondNoAbstract11.....\n";

	}
	void RequiredOperation2()const {
		std::cout << "Opeacja wymuszona1 z klasy secondNoAbstract1.....\n";
	}
	void RequiredOperation3()const {
		std::cout << "Opeacja wymuszona2 z klasy secondNoAbstract1.....\n";
	}
	void OtherOperation2() const override {
		std::cout << "Opeacja opcjonalna2 z klasy secondNoAbstract1.....\n";
	}
};

