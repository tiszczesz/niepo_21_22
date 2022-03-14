#include <iostream>
#include <cstdlib>
#include "Singleton.h"

using namespace std;

int main() {
	Singleton* ps = &Singleton::GetInstance();
	ps->HelloFromSingleton();
	cout << ps << endl;
	Singleton* ps2 = &Singleton::GetInstance();
	cout << ps2 << endl;
	ps2->SetStringValue("ala ma kota");
	ps2->HelloFromSingleton();
	ps->HelloFromSingleton();
	Singleton* s3 = ps2;
	Singleton& s4 = Singleton::GetInstance();
	cout << s3 << endl;
	cout << &s4 << endl;
	//Singleton::GetInstance().HelloFromSingleton();
	//delete ps;
	return 0;
}