#pragma once
#include <cstdlib>
#include <ctime>
#include <vector>
class GenerNumber
{
public:
	static int GenerEven() {
		return rand()*2;
	}
	static std::vector<int> GetEvenNumbers(size_t size) {
		std::vector<int> result;
		for(size_t i=0;i<size;i++) {
			result.push_back(GenerEven());
		}
		return result;
	}
	static int GetDividedBy(int divisor) {
		return rand() * divisor;
	}
	static int GetPrimalRandom() {
		srand(time(0));
		int result = 0;
		do {
			result = rand();
		} while (!isPrimal(result));
		return result;
	}
	static std::vector<int> GetAllPrimalFrom(int low, int up) {
		std::vector<int> result;
		if (low >= up) return result;
		//result.push_back(2);
		return result;
	}

private:
	static bool isPrimal(int number) {
		if (number <= 1) return false;
		for (size_t i = 2; i * i <= number; i++) {
			if (number%i==0) return false;
		}
		return true;
	}
};

