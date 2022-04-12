#include <iostream>
#include <cstdlib>
#include <string>

#include "FirstNoAbstract.h"
#include "SecondNoAbstract.h"
#include "ClientClass.h"

using namespace std;
int main() {
	FirstNoAbstract* f1 = new FirstNoAbstract();
	SecondNoAbstract* s1 = new SecondNoAbstract();
	ClientClass c1;

	c1.DoMethod(f1);
	cout << " ----------------------   IIIIII -------------------\n\n";
	c1.DoMethod(s1);

	delete f1;
	f1 = nullptr;
	delete s1;
	s1 = nullptr;
	return 0;
}