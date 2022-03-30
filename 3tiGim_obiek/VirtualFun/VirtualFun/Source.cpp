#include <iostream>
#include <cstdlib>
#include <string>

#include "DerivedClassOne.h"
#include "DerivedClassTwo.h"
#include "Repo.h"
using namespace std;

int main() {
	vector<BaseClass*> repo = Repo::GetAll();
	return 0;
}