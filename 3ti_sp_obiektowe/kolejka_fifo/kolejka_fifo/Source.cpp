//wwww.algorytm.edu.pl
#include<iostream>
#include <vector>
using namespace std;
struct Item {
	string value;
	Item* next=nullptr;
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
			first = last; 		
			first->next = nullptr;  
			isEmpty = false;
		}
		else
		{
			el = new Item;    //utworzenie nowego elementu kolejki
			el->value = x;	//przypisanie do niego wartosci
			last->next = el;	//ostatni dotychczas value wskazuje na utworzony
			last = el;				//value utworzony staje si? ostatnim
		}
		++lastIndex;
	}
	string pop_back()
	{
		if (lastIndex - firstIndex == 0) return ""; //gdy nie ma nic w kolejce zwracamy 0
		el = first;
		first = first->next;
		string result = el->value;
		delete el;		
		++firstIndex;
		isEmpty = firstIndex != lastIndex;
		return result;
	}
	string GetFirst() 
	{
		if (first == nullptr) return "";
		return first->value;
	}
	string GetLast() 
	{
		if (last == nullptr) return "";
		return last->value;
	}
private:
	bool isEmpty; 
	
	unsigned int firstIndex, lastIndex; 
	Item* first, * last, * el; 
};

int main()
{
	{
		Queue queue; //utworzenie kolejki
		vector<string> sentence{ "Ala","ma","kota","o","ciemnej","masci" };
		for (string word : sentence) {
			queue.push_back(word);
		}
		std::cout << "Rozmiar po zaladowniu: " << queue.size() << endl;
		
		while(queue.size()>0){
			std::cout << "===  " << queue.pop_back() <<" Aktualny rozmiar kolejki: "<<queue.size()<< endl;
		}
		cout << "Po zdjeciu wszystkich elementow rozmiar kolejki: " << queue.size() << endl;
		
		//wrzucic do kolejki push_back() i wyciagac pojedynczo pop_back()

	//	queue.push_back("value 1");
	//	cout << "Liczba elementow w kolejce: " << queue.size() << endl;
	//	queue.push_back("value 2");
	//	cout << "Liczba elementow w kolejce: " << queue.size() << endl;
	//	queue.push_back("value 3");
	//	cout << "Liczba elementow w kolejce: " << queue.size() << endl;
	//	cout << "Pierwszy value kolejce: " << queue.GetFirst() << endl;
	//	cout << "Ostatni value kolejce: " << queue.GetLast() << endl;

	//	cout << "usuwamy element o wartosci: " << queue.pop_back() << endl;

	//	cout << "usuwamy element o wartosci: " << queue.pop_back() << endl;
	//	cout << "Liczba elementow w kolejce: " << queue.size() << endl;
	//	/*cout << "usuwamy element o wartosci: " << queue.pop_back() << endl;*/

	//	cout << "Liczba elementow w kolejce: " << queue.size() << endl;
	//	if (queue.size() == 0)
	//		cout << "Queue jest pusta, nie ma nic do usuwania" << endl;
		
	}
	
	std::cout << "koniec programu" << endl;
	
	return 0;
}