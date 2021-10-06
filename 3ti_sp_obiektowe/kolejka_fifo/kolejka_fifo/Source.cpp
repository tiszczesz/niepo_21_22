//wwww.algorytm.edu.pl
#include<iostream>
using namespace std;
struct Item {
	string value;
	Item* next;
};
class Queue {
public:
	Queue() {
		firstIndex = 0;
		lastIndex = 0;
		isEmpty = true;
	}
	~Queue() 
	{
		while (lastIndex - firstIndex > 0) {
			el = first;
			first = first->next;
			delete el;
			++firstIndex;
		}
		if (!isEmpty)
			delete first;
	}
	unsigned int size() { return lastIndex - firstIndex; }
	void push_back(string x)
	{
		if (isEmpty)//jesli pusta
		{
			last = new Item;    
			last->value = x; 
			first = new Item; 		
			first->next = last;  
			isEmpty = false;
		}
		else
		{
			el = new Item;    //utworzenie nowego elementu kolejki
			el->value = x;	//przypisanie do niego wartosci
			last->next = el;	//ostatni dotychczas value wskazuje na utworzony
			last = el;				//value utworzony staje siê ostatnim
		}
		++lastIndex;
	}
	string pop_back()
	{
		if (lastIndex - firstIndex == 0)return ""; //gdy nie ma nic w kolejce zwracamy 0
		el = first;
		first = first->next;
		string result = el->value;
		delete el;		
		++firstIndex;
		return result;
	}
	string GetFirst() 
	{
		return first->next->value;
	}
	string GetLast() 
	{
		return last->value;
	}
private:
	bool isEmpty; 
	
	unsigned int firstIndex, lastIndex; 
	Item* first, * last, * el; 
};

int main()
{
	Queue queue; //utworzenie kolejki

	queue.push_back("value 1"); 
	cout << "Liczba elementow w kolejce: " << queue.size() << endl; 
	queue.push_back("value 2"); 
	cout << "Liczba elementow w kolejce: " << queue.size() << endl; 
	queue.push_back("value 3"); 
	cout << "Liczba elementow w kolejce: " << queue.size() << endl; 
	cout << "Pierwszy value kolejce: " << queue.GetFirst() << endl; 
	cout << "Ostatni value kolejce: " << queue.GetLast() << endl;   
	
	cout << "usuwamy element o wartosci: " << queue.pop_back() << endl;
	
	cout << "usuwamy element o wartosci: " << queue.pop_back() << endl;
	cout << "Liczba elementow w kolejce: " << queue.size() << endl; 
	cout << "usuwamy element o wartosci: " << queue.pop_back() << endl;
	
	cout << "Liczba elementow w kolejce: " << queue.size() << endl; 
	if (queue.size()==0)
		cout << "Queue jest pusta, nie ma nic do usuwania" << endl;

	return 0;
}