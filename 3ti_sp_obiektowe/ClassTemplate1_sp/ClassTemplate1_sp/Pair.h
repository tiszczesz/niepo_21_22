#pragma once
#include <cmath>
#include <ostream>
struct Pair
{
//public:
	int a, b;
	friend std::ostream& operator<<(std::ostream& os, const Pair& p);
	friend bool operator>(const Pair& p1, const Pair& p2);
};
//todo abs >  <<
