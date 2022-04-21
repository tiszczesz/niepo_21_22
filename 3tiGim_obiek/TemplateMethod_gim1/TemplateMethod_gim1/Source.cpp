#include <iostream>
#include <cstdlib>
#include <string>
#include "MyAbstractClass.h"
#include "FirstClass.h"
#include "SecondClass.h"

using namespace std;

int main() {
	MyAbstractClass* f1 = new FirstClass();
	MyAbstractClass* s1 = new SecondClass();
	f1->TemplateMethod();
	cout << " \n ===========================\n\n";
	s1->TemplateMethod();
	delete f1;
	f1 = nullptr;
	delete s1;
	s1 = nullptr;
	return EXIT_SUCCESS;
}