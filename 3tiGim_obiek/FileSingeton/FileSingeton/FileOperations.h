#pragma once
#include <string>
#include <vector>
#include <fstream>
#include <iostream>

class FileOperations // implementuje wzorzec singleton
{
private:
	std::string filename;
	FileOperations(){};
	FileOperations(const FileOperations& ob){};
	~FileOperations(){};
	void operator=(const FileOperations& ob);

public:
	static FileOperations& GetInstance() {
		static FileOperations _instance;
		return _instance;
	}
	void SetFileName(std::string filename) {
		this->filename = filename;
	}
	std::vector<std::string> GetFileContent() {
		std::ifstream sf;
		std::vector<std::string> result;
		
		sf.open(filename.c_str());
		if(sf.is_open()) {
			
			std::string line;
			while(std::getline(sf,line)) {
				result.push_back(line);
			}			
		}else {
			std::cout << "file no exists" << std::endl;
		}
		return result;
	}
	//todo SaveToFile from vector to file
};

