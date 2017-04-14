#include<iostream>
#include<fstream>
#include<stdlib.h>
#include <ctime>
using namespace std;

string ChoosingWord ( int Theme )
{
	srand( time( 0 ) );
	string Word;
	ifstream File;
	int i = 0, Number;
	Number = rand() % 10 + 1;
	switch( Theme )
	{
		case 1:
			File.open( "1.txt" );
			while ( i != Number )
			{
				getline ( File, Word );
				i++;
			}
			File.close(); break;
		case 2:
			File.open( "2.txt" );
			while ( i != Number )
			{
				getline ( File, Word );
				i++;
			}
			File.close(); break;
		case 3:
			File.open( "3.txt" );
			while ( i != Number )
			{
				getline ( File, Word );
				i++;
			}
			File.close(); break;
		case 4:
			File.open( "4.txt" );
			while ( i != Number )
			{
				getline ( File, Word );
				i++;
			}
			File.close(); break;
		case 5:
			File.open( "5.txt" );
			while ( i != Number )
			{
				getline ( File, Word );
				i++;
			}
			File.close(); break;
		case 6:
			File.open( "6.txt" );
			while ( i != Number )
			{
				getline ( File, Word );
				i++;
			}
			File.close(); break;
	}
	return Word;	
}
int main()
{
	int NumberOfTheme;
	string Word;
	cin>>NumberOfTheme;
	Word = ChoosingWord( NumberOfTheme );
	cout<<Word;
}
