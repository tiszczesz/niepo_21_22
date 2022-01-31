#include "pch.h"
#include "CppUnitTest.h"
#include "../FirstcppWithTests/GenerNumber.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MyUnitTest
{
	TEST_CLASS(MyUnitTest)
	{
	public:
		
		TEST_METHOD(Even_Test)
		{
			GenerNumber gn;
			int ff = gn.GenerEven();
			Assert::IsTrue(ff % 2 == 0);
		}
	};
}
