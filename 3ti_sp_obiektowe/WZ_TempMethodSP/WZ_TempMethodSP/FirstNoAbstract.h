#pragma once
#include "MyAbstract.h"

class FirstNoAbstract : public MyAbstract
{
protected:
	void RequiredOperation1()const  {
		std::cout << "Opeacja z klasy firstNoAbstract11.....\n";
		
	}
	void RequiredOperation2()const {
		std::cout << "Opeacja wymuszona1 z klasy firstNoAbstract1.....\n";
	}
	void RequiredOperation3()const {
		std::cout << "Opeacja wymuszona2 z klasy firstNoAbstract1.....\n";
	}
	void OtherOperation1() const override {
		std::cout << "Opeacja opcjonalna1 z klasy firstNoAbstract1.....\n";
	}
};

