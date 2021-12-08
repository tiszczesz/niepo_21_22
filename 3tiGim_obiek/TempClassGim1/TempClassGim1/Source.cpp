#include <iostream>
#include <cstdlib>
#include <string>
#include "Container.h"
#include <vector>
using namespace std;

int main() {
	vector<string> v1{"ala", "mela", "Bella", "ciela"};
	vector<int> numbers{ 12,6,8,9,0,23 };//na stosie ->w momencie kompliacji
	Container<string>* c1 = new Container<string>(v1);//na stercie przy uruchomieniu
	Container<int> liczby(numbers);
	(*c1).ShowAll();
	c1->ShowAll();
	delete c1;
	c1 = nullptr;
	if(c1!=nullptr) {
		string elem = "jeszcze jeden element";
		c1->AddNew(elem);
		c1->ShowAll();
	}else {
		cout << "dsfsd fsd f";
	}
	return EXIT_SUCCESS;
}