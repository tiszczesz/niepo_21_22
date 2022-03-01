#include "pch.h"
#include "CppUnitTest.h"
#include "../FakeTests/FakeStrings.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			std::string toTest = "alaa ";
			int result = FakeStrings::GetChars(toTest);
			Assert::AreEqual(5, result);
		}
		TEST_METHOD(TestMethod2)
		{
			std::string toTest = "alaa 3333";
			int result = FakeStrings::GetLetter(toTest);
			Assert::AreEqual(4, result);
		}
	};
}
