#include "pch.h"
#include "CppUnitTest.h"
#include "../ConsoleWithTest1_cpp/Numbers.h"
#include <vector>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace NativeUTest1
{
	TEST_CLASS(NativeUTest1)
	{
		
	public:
		
		TEST_METHOD(TestMethod1)
		{
			Numbers numbers;
			int result1 = numbers.RandomEven();
			bool isEven = result1 % 2 == 0;
			Assert::IsTrue(isEven);
		}
		TEST_METHOD(TestMethod2)
		{
			Numbers numbers;
			int result1 = numbers.RandomEven();
			int result2 = numbers.RandomEven();			
			Assert::IsFalse(result1 == result2);
		}
		TEST_METHOD(TestMethod3)
		{
			Numbers numbers;
			std::vector<int> result = numbers.RandomPrimal(5, 2);
			
			Assert::IsTrue(result.size()==0);
		}

		TEST_METHOD(TestMethod5) {
			Assert::IsTrue(isPrimal(5));
		}

		TEST_METHOD(Test_size_primals_vector) {
			Numbers numbers;
			std::vector<int> result = numbers.RandomPrimal(2, 6);
			Assert::IsTrue(result.size()==3);
		}

		TEST_METHOD(Test_primals_in_vector) {
			Numbers numbers;
			std::vector<int> result = numbers.RandomPrimal(2, 6);
			//result.push_back(4);
			for (int number : result) {
				Assert::IsTrue(isPrimal(number));
			}			
		}

		TEST_METHOD(Test_divide_by_divider) {
			Numbers numbers;
			int divider = 3;
			int result = numbers.RandomDividedBy(divider);
			//result.push_back(4);
			Assert::IsTrue(result % divider == 0);
		}

		bool isPrimal(int number) {
			if (number < 2) false;
			for(int i=2;i*i<=number;i++) {
				if (number % i == 0) return false;
			}
			return true;
		}
	};
}
