#pragma once
#include <cstdlib>
#include <ctime>
#include <thread>
#include <cstdlib>
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
	int RandomPrimal(int low,int up) {
		if (low >= up) return 2;
		return rand();
	}
};

