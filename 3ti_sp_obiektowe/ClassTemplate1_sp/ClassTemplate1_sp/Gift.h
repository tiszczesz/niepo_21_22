#pragma once
#include <string>
#include <iostream>
class Gift
{
private:
	std::string name;
	std::string owner;
	double price;
public:
	Gift(); //todo
	Gift(std::string name, std::string owner, double price); //todo
	//todo
	std::string GetName() {
		return name;
	}
	double GetPrice() {
		return price;
	}
	std::string GetOwner() {
		return owner;
	}
	
};

