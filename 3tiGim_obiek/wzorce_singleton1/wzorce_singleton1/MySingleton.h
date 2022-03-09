#pragma once
#include <iostream>
#include <string>

class MySingleton
{
private:
	int number{ 8 };
	std::string text{ "jakis tekst" };
	MySingleton(){}
	~MySingleton(){}
	MySingleton(const MySingleton& s){}
	void operator=(const MySingleton& s);

public:
	static MySingleton& GetInstance() {
		static MySingleton _instance;
		return _instance;
	}
	void InfoFromSingleton() {
		std::cout << "Hello from Singleton...." << std::endl;
		std::cout << "number = " << number << " text = " << text << std::endl;
	}
	void SetNumber(int number) {
		this->number = number;
	}
	void SetText(std::string  text) {
		this->text = text;
	}
};

