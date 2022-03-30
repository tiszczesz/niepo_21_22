#include <iostream>
#include <cstdlib>
#include <string>

#include "DerivedClassOne.h"
#include "DerivedClassTwo.h"
#include "Repo.h"
using namespace std;

int main() {
	Repo repo;
	vector<BaseClass*> items = repo.GetAll();
	for (BaseClass* item : items) {
		item->ToOverride();
	}
	return 0;
}