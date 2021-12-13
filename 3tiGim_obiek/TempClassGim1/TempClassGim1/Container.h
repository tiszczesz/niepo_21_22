#pragma once
#include <vector>
#include <iostream>
#include <algorithm>
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
	void AddNew(T& item) {
		data.push_back(item);
	}
	Container<T> GetSort() {
		Container<T> result = (*this);
		//result.data.
		return  result;
	}
};

