#include "Stack.h"

Stack::Stack() {
	count = 0;
	top = nullptr;
}
std::ostream& operator<<(std::ostream& os, const Stack& stack) {
	if (stack.GetCount() == 0) {
		os << "Stos jest pusty!!!" << std::endl;
		return os;
	}
	os << "Informocje o stosie: rozmiar: " << stack.GetCount() << std::endl;
	Item* temp = stack.GetTop();
	while (true) {
		//todo
	}
	
}

