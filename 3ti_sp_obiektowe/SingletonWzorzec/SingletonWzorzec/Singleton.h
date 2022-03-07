#pragma once
#include <iostream>
#include <string>
class Singleton
{
private:
	int value{ 6 };
	std::string stringValue{ "noname" };
	Singleton() {} //konstruktor
	Singleton(const Singleton& s) {} //konstruktor kopiuj¹cy
	~Singleton(){} //destruktor
	void operator=(const Singleton& s);

public:
	static Singleton& GetInstance() {
		static Singleton _instance;
		return _instance;
	}
	void HelloFromSingleton() {
		std::cout << "Hello from singleton..." << std::endl;
		std::cout << value << " ---- " << stringValue << std::endl;
	}
	void SetValue(int value) {
		this->value = value;
	}
	void SetStringValue(std::string value) {
		this->stringValue = value;
	}
};

