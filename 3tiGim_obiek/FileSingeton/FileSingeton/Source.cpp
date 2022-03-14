#include <iostream>
#include <cstdlib>
#include <string>
#include "FileOperations.h"
using namespace std;

int main() {
	FileOperations& sf = FileOperations::GetInstance();
	string filename = "text.txt";
	sf.SetFileName(filename);
	auto result = sf.GetFileContent();
	for (string line : result) {
		cout << line << endl;
	}
	return 0;
}