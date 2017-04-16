#include<iostream>
#include<fstream>
#include<stdlib.h>
#include<ctime>
using namespace std;

int main()
{
	srand( time( 0 ) );
	int NumberOfTheme;
	string Word;
	cin>>NumberOfTheme;
	ifstream File;
	int i = 0, Number;
	Number = rand() % 10 + 1;
		
	switch( NumberOfTheme )
	{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
	}
	
	return 0;	
}
