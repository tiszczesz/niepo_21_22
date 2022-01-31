#include "pch.h"
#include "CppUnitTest.h"
#include "../ConsoleWithTest1_cpp/Numbers.h"

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
			int result1 = numbers.RandomPrimal(2, 2);
			
			Assert::AreEqual(2,result1);
		}
		TEST_METHOD(TestMethod4)
		{
			Numbers numbers;
			int result1 = numbers.RandomPrimal(2, 2);

			Assert::AreEqual(2, result1);
		}
		TEST_METHOD(TestMethod5) {
			Assert::IsTrue(isPrimal(5));
		}

		TEST_METHOD(TestMethod6) {
			Numbers numbers;
			int result1 = numbers.RandomPrimal(2, 5);
			Assert::IsTrue(isPrimal(result1));
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
