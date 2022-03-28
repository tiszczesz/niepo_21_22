#pragma once
#include <iostream>
#include <string>
class MainClass // abstrakcyjna bo jest przyjmniej jedna metoda czysto wirtualna
{
protected:
	std::string value;
public:
	std::string GetValue() {
		return value;
	}

	MainClass() {
		value = "no value";
	}
	MainClass(std::string val):value(val){}
	virtual void ToOverride() = 0; //czysto wirtualna
	/*{
		std::cout << "Metoda do nadpisania...." << std::endl;
	}*/
};

