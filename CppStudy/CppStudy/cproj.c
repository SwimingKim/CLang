#include <stdio.h>
#define EOF -1

main()
{
	printf("hello, world\n");

	// for문
	int fahr;

	for (int i = 0; i < 10; i++)
	{
		printf("%d\n", i);
	}

	/*
	//파일 복사 프로그램
	int c;
	while ((c=getchar()) != EOF)
	{
		putchar(c);
	}
	*/

	// 포인터
	
	int x = 1, y = 2, z[10];
	int* ip;
	
	//변수(int a) -> 값(a) 주소(&a)
	//포인터(int* pA) -> 값(*pA) 주소(pA)
	//레퍼런스(int& rA)

	ip = &x;
	printf("%d	%d	%d\n", x, y, *ip);
	y = *ip;
	printf("%d	%d	%d\n", x, y, *ip);
	*ip = 0;
	printf("%d	%d	%d\n", x, y, *ip);
	ip = &z[0];

}