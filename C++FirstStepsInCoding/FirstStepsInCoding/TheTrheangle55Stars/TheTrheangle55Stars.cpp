// TheTrheangle55Stars.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

	using namespace std;
	int main()

	{
		int stars = 1;
		for (int line = 0; line < 10; line++)
		{
			for (int s = 0; s < stars; s++)
				cout << "*";
			stars += 1;
			cout << endl;
		}
	return(0);
	}
