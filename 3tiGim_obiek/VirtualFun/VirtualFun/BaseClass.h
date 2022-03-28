#pragma once
#include <iostream>

class BaseClass
{
protected:
	int value{ 0 };
public:
	BaseClass(){}
	BaseClass(int value) {
		this->value = value;
	}
	void ToOverride() {
		std::cout << "Do nadpisania...." << std::endl;
	}
};

