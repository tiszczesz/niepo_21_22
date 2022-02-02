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
		TEST_METHOD(Even_Test_Static)
		{			
			int ff = GenerNumber::GenerEven();
			Assert::IsTrue(ff % 2 == 0);
		}
		TEST_METHOD(Even_Test_Two_numbers)
		{
			int ff1 = GenerNumber::GenerEven();
			int ff2 = GenerNumber::GenerEven();
			Assert::IsTrue(ff1!=ff2);
		}
		TEST_METHOD(Even_Test_vector_numbers)
		{
			std::vector<int> result = GenerNumber::GetEvenNumbers(3);
			std::vector<int> result2 = GenerNumber::GetEvenNumbers(3);
			//Assert::IsTrue(ff1 != ff2);
		}
	};
}
