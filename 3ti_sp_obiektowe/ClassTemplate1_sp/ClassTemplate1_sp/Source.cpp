#include <iostream>
#include <cstdlib>
#include <string>
#include "Box.h"
#include "Pair.h"

using namespace std;
void Ex1();
void Ex2();
int main() {
	//Ex1();
	//Ex2();
	return EXIT_SUCCESS;
}
void Ex2() {
	//Utworzyc klase Gift (name, price,  owner)
	//Wykorzystac Box<Gift>  sortowanie po cenie max tez
}
void Ex1() {
	vector<int> liczby{ 12,7,8,9,0,1234,23 };
	Box<int> BoxOfNumbers = Box<int>(liczby);
	vector<Pair> pary = { {12,5},{5,8},{67,4},{-40,30} };
	vector<string> words{ "ala","bela","ryba","plywa","woda","soda" };
	Box<string>* BoxOfWords = new Box<string>(words);
	Box<Pair> BoxOfPair = Box<Pair>(pary);
	BoxOfPair.ShowAll();
	cout << "sortujemy pary....." << endl;
	Box<Pair> posortowanePary = BoxOfPair.SortAlg();
	posortowanePary.ShowAll();
	cout << "\n=====================================\n\n";
	/*BoxOfNumbers.ShowAll();
	BoxOfNumbers.Add(999);
	BoxOfNumbers.ShowAll();*/
	BoxOfWords->ShowAll();
	cout << " max = " << BoxOfWords->GetMax() << endl;
	cout << " max = " << BoxOfPair.GetMax() << endl;
	delete BoxOfWords;
	BoxOfWords = nullptr;
}