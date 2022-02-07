#pragma once
#include <cstdlib>
#include <ctime>
#include <thread>
#include <cstdlib>
#include <vector>
using namespace std::this_thread;
using namespace std::chrono_literals;
class Numbers
{
public:
	Numbers() {
		srand(time(NULL));
	}
	
	int RandomEven() {		
		int random = rand();
		return random*2;
	}

	std::vector<int> RandomPrimal(int low,int up) {
		std::vector<int> result;
		if (low >= up) return result;
		for(size_t i=low; i<=up;i++) {
			if(isPrimal(i)) {
				result.push_back(i);
			}
		}
		return result;
	}
	int RandomDividedBy(int divider) {
		return rand()*divider;
	}
private:
	bool isPrimal(int number) {
		if (number < 2) false;
		for (int i = 2; i * i <= number; i++) {
			if (number % i == 0) return false;
		}
		return true;
	}
};

