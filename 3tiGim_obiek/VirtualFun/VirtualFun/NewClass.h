#pragma once
#include "BaseClass.h"
class NewClass :    public BaseClass
{
public:
	void ToOverride() {
		std::cout << "<<<<<<Nadpisana w NOWA NOWA..>>>>" << std::endl;
	}
};

