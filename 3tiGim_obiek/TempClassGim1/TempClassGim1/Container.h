#pragma once
#include <vector>
#include <iostream>
template<typename  T>
class Container
{
private:
	std::vector<T> data;
public:
	Container() {};
	Container(std::vector<T>& data) {
		this->data = data;
	}
	void ShowAll() {
		for (T item : data) {
			std::cout << item << std::endl;
		}
	}
};

