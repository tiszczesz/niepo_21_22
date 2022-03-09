#include <iostream>
#include <cstdlib>
#include "MySingleton.h"

using namespace std;

int main() {
	MySingleton& s1 = MySingleton::GetInstance();
	s1.InfoFromSingleton();
	MySingleton& s2 = MySingleton::GetInstance();
	s2.SetNumber(56);
	s2.SetText("ala ma kota");
	cout << " ==================================== \n";
	s1.InfoFromSingleton();
	s2.InfoFromSingleton();
	cout << &s1 << endl;
	cout << &s2 << endl;
	return 0;
}