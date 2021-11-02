#pragma once
#include <string>
#include <vector>
#include <iostream>

class Words
{
private:
	const static int MAX_SIZE = 100;
	std::string data[MAX_SIZE];
	int size{ 10 };
	void SetSize(int size) {
		if (size < 0) size = -size;
		if (size > MAX_SIZE) this->size = MAX_SIZE;
		else {
			this->size = size;
		}
	}
public:
	Words();
	Words(std::vector<std::string> initData);
	Words(int size);

	std::string GetMaxLengthString();
	std::string GetMinLengthString();
	int FindWord(std::string toSearch);   // zwraca indeks w tablicy lub -1 jak takiego s³owa nie ma
	std::vector<std::string> OrderBy(bool isAsc); //sortowanie s³ownikowe s³ów 
	friend std::ostream operator<<(std::ostream& os, const Words& words);
};

