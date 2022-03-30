#pragma once
#include <iostream>

class BaseClass //abstrakcyjna
{
protected:
	int value{ 0 };
public:
	BaseClass(){}
	BaseClass(int value) {
		this->value = value;
	}
	virtual void ToOverride() = 0; //czysto wirtualna metoda
};

