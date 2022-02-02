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
		return 5;
	}
};

