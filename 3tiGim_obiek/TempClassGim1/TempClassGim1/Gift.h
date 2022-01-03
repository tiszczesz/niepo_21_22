#include <string>
#include <iostream>
#pragma once

class Gift
{
private:
	std::string name;
	std::string owner;
	double price;

public:
	Gift();
	Gift(std::string name, std::string owner, double price);
	std::string GetName() {
		return name;
	}
	std::string GetOwner() {
		return owner;
	}
	double GetPrice() {
		return price;
	}
};

