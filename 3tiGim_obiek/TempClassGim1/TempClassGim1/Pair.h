#pragma once
#include <ostream>
#include <iostream>
#include <cmath>
struct Pair
{
	int a, b;
	friend std::ostream& operator<<(std::ostream& os, const Pair& p);
	//bool operator<(const Pair& p) {
	//	return abs(this->a - this->b) < abs(p.a - p.b);
	//}
	friend bool operator<(const Pair& p1, const Pair& p2);
	friend bool operator>(const Pair& p1, const Pair& p2);
	friend bool operator==(const Pair& p1, const Pair& p2);
};







