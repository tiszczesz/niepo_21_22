#include <iostream>
#include <cstdlib>
#include <string>

#include "DerivedClassOne.h"
#include "DerivedClassTwo.h"
using namespace std;

int main() {
	DerivedClassOne d1;
	DerivedClassTwo d2;
	d1.ToOverride();
	d2.ToOverride();
	return 0;
}