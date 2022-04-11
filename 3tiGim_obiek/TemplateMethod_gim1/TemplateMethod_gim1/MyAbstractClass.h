#pragma once
#include <iostream>

class MyAbstractClass
{
public:
	void TemplateMethod() const {
		this->BaseOperation1();
		this->RequiredOperations1();
		this->BaseOperation2();
		this->Hook1();
		this->RequiredOperations2();
		this->BaseOperation3();
		this->Hook2();
	}
protected:
	void BaseOperation1() const {
		std::cout << "Klasa abstrakcyjna czynnosc 1.....\n";
	}
	void BaseOperation2() const {
		std::cout << "Klasa abstrakcyjna czynnosc 2.....\n";
	}
	void BaseOperation3() const {
		std::cout << "Klasa abstrakcyjna czynnosc 3.....\n";
	}
	virtual void RequiredOperations1() const = 0;
	virtual void RequiredOperations2() const = 0;
	virtual void Hook1() const {}
	virtual void Hook2() const {}
};

