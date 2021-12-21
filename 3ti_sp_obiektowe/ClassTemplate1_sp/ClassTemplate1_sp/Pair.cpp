#include "Pair.h"
std::ostream& operator<<(std::ostream& os, const Pair& p) {
	os << '(' << p.a << ',' << p.b << ')';
	return os;
}
bool operator>(const Pair& p1, const Pair& p2) {
	return abs(p1.a - p1.b) > abs(p2.a - p2.b);
}

bool operator<(const Pair& p1, const Pair& p2) {
	return abs(p1.a - p1.b) < abs(p2.a - p2.b);
}
bool operator==(const Pair& p1, const Pair& p2) {
	return abs(p1.a - p1.b) == abs(p2.a - p2.b);
}