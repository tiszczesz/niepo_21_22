#pragma once
#include "MainClass.h"
class DerivedThreeClass :    public MainClass
{
public:
	void ToOverride() {
		std::cout << "Zupelnie inne dzialanie w klasie DerivedThreeClass!!!!" << std::endl;
	}
};

