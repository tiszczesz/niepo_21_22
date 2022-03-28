#include <iostream>
#include <cstdlib>
using namespace std;
#include "DerivedOneClass.h"
#include "DerivedTwoClass.h"
#include "Repo.h"
void Cw1();
int main() {
	/*MainClass mc;
	DerivedOneClass d1;
	DerivedTwoClass d2;
	mc.ToOverride();
	d1.ToOverride();
	d2.ToOverride();*/
	Cw1();
	cout << "dfgdfgdgdg dfg dgdfgdf gd g\n\n";
	return 0;
}

void Cw1() {
	Repo repo;
	vector<MainClass*> dane = repo.GetItems();
	for (int i = 0; i < dane.size(); i++) {
		dane[i]->ToOverride();
	}
}