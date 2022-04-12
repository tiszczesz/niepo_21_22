#pragma once
#include <iostream>

class MyAbstract
{
public:
	void TemplateMethod() const {
		this->RequiredOperation1();
		this->BaseOperation1();
		this->BaseOperation2();
		this->RequiredOperation2();
		this->OtherOperation1();
		this->RequiredOperation3();
		this->OtherOperation2();
	}
protected:
	void BaseOperation1() const {
		std::cout << "Operacja z klasy MyAbstract1\n";
	}
	void BaseOperation2() const {
		std::cout << "Operacja z klasy MyAbstract2\n";
	}
	virtual void OtherOperation1() const {}
	virtual void OtherOperation2()const {}
	virtual void RequiredOperation1()const = 0;
	virtual void RequiredOperation2()const = 0;
	virtual void RequiredOperation3()const = 0;
};

