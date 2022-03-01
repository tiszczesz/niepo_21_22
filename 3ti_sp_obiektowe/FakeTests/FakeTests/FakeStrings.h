#pragma once
#include <string>
#include <cctype>

class FakeStrings
{
public:
	static int GetChars(std::string text) {
		return text.size();
	}
	static int GetLetter(std::string text) {
		int result = 0;
		for (size_t i=0;i<text.size();i++) {
			if (isalpha(text[i])) result++;
		}
		return result;
	}
};

