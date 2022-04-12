#pragma once
#include "MyAbstract.h"


class ClientClass
{

public:
	void DoMethod(MyAbstract* a) {
		a->TemplateMethod();
		//(*a).TemplateMethod();
	}
};

