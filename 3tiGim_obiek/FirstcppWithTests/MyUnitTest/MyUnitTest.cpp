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
			std::vector<int> result = GenerNumber::GetEvenNumbers(8);
			for(size_t i=0;i<result.size();i++) {
				Assert::IsTrue(result[i] % 2 == 0);
			}
			//Assert::IsTrue(ff1 != ff2);
		}
		TEST_METHOD(Divide_Test_number)
		{
			int number = 12;
			int result = GenerNumber::GetDividedBy(number);
			
			Assert::IsTrue(result%number ==0);
		}
		TEST_METHOD(Primal_Test_number)
		{
			int result = GenerNumber::GetPrimalRandom();
			Assert::IsTrue(isPrimal(result));
		}
	
	TEST_METHOD(Primal_vector_size)
	{
		std::vector<int> result = GenerNumber::GetAllPrimalFrom(4,3);
		Assert::IsTrue(result.size()==0);
	}

	/*TEST_METHOD(Primal_vector_size2)
	{
		std::vector<int> result = GenerNumber::GetAllPrimalFrom(3, 7);
		Assert::IsTrue(result.size() != 0);
	}*/
	/*	TEST_METHOD(Primal_Test_number2)
		{
			int result = 6;
			Assert::IsTrue(isPrimal(result));
		}*/
		static bool isPrimal(int number) {
			if (number <= 1) return false;
			for (size_t i = 2; i * i <= number; i++) {
				if (number % i == 0) return false;
			}
			return true;
		}
	};
}
