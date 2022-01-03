#pragma once
#include <vector>
#include <iostream>
#include <stdexcept>
#include <algorithm>
template<typename  T>
class Box
{
private:
	std::vector<T> data;
public:
	Box() {
		//todo
	}
	Box(std::vector<T>& data) {
		this->data = data;
	}
	void Add(T item) {
		data.push_back(item);
	}
	void ShowAll() {
		std::cout << "\t-----START-----" << std::endl;
		for (T item : data) {
			std::cout << item << std::endl;
		}
		std::cout << "\t-----END-----" << std::endl;
	}
	T GetMax() {
		if (data.size() == 0) throw std::invalid_argument("Brak danych");
		T max = data[0];
		for (T item : data) {
			if (item > max) max = item;
		}
		return max;
	}
	Box SortBubble(bool order=true);  //ma zwarac nowy obiekt Box posortowany
	Box SortAlg() {
		std::vector<T> result = data;
		std::sort(result.begin(), result.end());  //n*ln( n)
		Box sortBox(result);
		return sortBox;
	}  //ma zwarac nowy obiekt Box posortowany
};

