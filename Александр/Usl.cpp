#include <stdio.h>
#include <stdlib.h>

static char * word1;
static char * word2;

static int x = 0;

void setWord(char ch[]){
	word1 = ch;
	word2 = new char;
	for(int i = 0; i < 4; i++){
		word2[i] = ' ';
	//	printf("%c",word2[i]);
	}
}

char * getWord(char ch){
}

void printMas(){
	for(int i = 0; i<4; i++){
		printf("%c",word1[i]);
	}
	
	printf("\n");
	
	printf("(");
	for(int i = 0; i<4; i++){
		printf("%c",word2[i]);
	}
	printf(")\n");
}

main(){
	char c[] = "1234";
	setWord(c);	
	printMas();
}
