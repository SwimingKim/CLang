#include <stdio.h>
#define EOF -1

main()
{
	printf("hello, world\n");

	// for��
	int fahr;

	for (int i = 0; i < 10; i++)
	{
		printf("%d\n", i);
	}

	/*
	//���� ���� ���α׷�
	int c;
	while ((c=getchar()) != EOF)
	{
		putchar(c);
	}
	*/

	// ������
	
	int x = 1, y = 2, z[10];
	int* ip;
	
	//����(int a) -> ��(a) �ּ�(&a)
	//������(int* pA) -> ��(*pA) �ּ�(pA)
	//���۷���(int& rA)

	ip = &x;
	printf("%d	%d	%d\n", x, y, *ip);
	y = *ip;
	printf("%d	%d	%d\n", x, y, *ip);
	*ip = 0;
	printf("%d	%d	%d\n", x, y, *ip);
	ip = &z[0];

}