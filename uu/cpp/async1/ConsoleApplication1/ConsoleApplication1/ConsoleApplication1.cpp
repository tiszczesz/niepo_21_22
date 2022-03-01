// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <future>
#include <thread>

int fib(int n)
{
    if (n < 3) return 1;
    else return fib(n - 1) + fib(n - 2);
}

int main()
{
    std::future<int> f1 = std::async(std::launch::async, [] { return fib(35); });
    std::future<int> f2 = std::async(std::launch::async, [] { return fib(20); });

    std::cout << "waiting...\n";

    std::cout << "f1: " << f1.get() << '\n';
    std::cout << "f2: " << f2.get() << '\n';
}

