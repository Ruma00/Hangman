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
			File.open( "1.txt" );
		case 2:
			File.open( "2.txt" );
		case 3:
			File.open( "3.txt" );
		case 4:
			File.open( "4.txt" );
		case 5:
			File.open( "5.txt" );
		case 6:
			File.open( "6.txt" );
	}
	
	return 0;	
}
