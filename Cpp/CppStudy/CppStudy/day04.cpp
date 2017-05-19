#include <iostream>
using namespace std;

void pswap(int* pA, int* pB)
{
	int tmp = *pA;
	*pA = *pB;
	*pB = tmp;
}
void rswap(int& rA, int& rB)
{
	int tmp = rA;
	rA = rB;
	rB = tmp;
}

const int num = 5;
double avg(int t[]);
double pavg(int* pt);

int count(char str[], char ch)
{
	int i = 0;
	int c = 0;
	while (str[i])
	{
		if (str[i] == ch)
		{
			c++;
		}
		i++;
	}
	return c;
}

int sa = 0; // ���� ����

void func();

int main()
{
	// ������
	int* pA, a = 5, b = 10;
	pA = &a;
	cout << "*pA = " << *pA << " a = " << a << "\n";
	cout << "pA = " << pA << " &a = " << &a << "\n";
	pswap(pA, &a);
	cout << "*pA = " << *pA << " a = " << a << "\n";
	cout << "pA = " << pA << " &a = " << &a << "\n";
	a = b;
	cout << "*pA = " << *pA << " a = " << a << "\n";
	cout << "pA = " << pA << " &a = " << &a << "\n";

	// ���۷���
	/*
	int a = 5, b = 10;
	int& rA = a;
	cout << "rA = " << rA << " a = " << a << "\n";
	cout << "&rA " << &rA << " &a = " << &a << "\n";
	rswap(rA, a);
	cout << "rA = " << rA << " a = " << a << "\n";
	cout << "&rA = " << &rA << " &a = " << &a << "\n";
	a = b;
	cout << "&rA = " << &rA << " &a = " << &a << "\n";
	*/

	/*
	int test[5];
	test[0] = 80;
	test[1] = 60;
	test[2] = 22;
	test[3] = 50;
	test[4] = 75;
	*/
	const int num = 5;
	int test[num] = { 80, 60, 22, 50, 75 };

	for (int i=0; i < 5 ; i++)
	{
		cout << i + 1 << "��° ����� ������ " << test[i] << "�Դϴ�.\n";
 	}

	/*
	const int num = 5;
	int list[num];
	cout << num << "���� ������ �Է��ϼ���.\n";
	for (int i=0; i < num; i++)
	{
		cin >> test[i];
	}
	for (int i = 0; i < num; i++)
	{
		cout << i << "��° ����� ������ " << test[i] << "�Դϴ�.\n";
	}
	*/

	for (int i=0; i < num-1; i++)
	{
		for (int j=i+1; j < num; j++)
		{
			if (test[j] > test[i])
			{
				int tmp = test[i];
				test[i] = test[j];
				test[j] = tmp;
			}
		}
	}

	for (int i=0; i < num; i++)
	{
		cout << i + 1 << "���� ������ " << test[i] << "�Դϴ�.\n";
	}

	const int x = 2;
	const int y = 5;

	/*
	int mlist[x][y];
	mlist[0][0] = 80;
	mlist[0][1] = 60;
	mlist[0][2] = 22;
	mlist[0][3] = 50;
	mlist[0][4] = 75;
	mlist[1][0] = 90;
	mlist[1][1] = 55;
	mlist[1][2] = 68;
	mlist[1][3] = 72;
	mlist[1][4] = 58;
	*/
	int mlist[x][y] = { // �� �ε����� x�� ������ �����ϴ�
		{80, 60, 22, 50, 75},
		{90, 55, 68, 72, 58},
	};

	for (int i=0; i<num; i++)
	{
		cout << i + 1 << "��° �л��� ���������� " << mlist[0][i] << "�Դϴ�.\n";
		cout << i + 1 << "��° �л��� ���������� " << mlist[1][i] << "�Դϴ�.\n";
	}

	int tlist[5] = { 80, 60, 55, 22, 75 };
	// *tlist[0] = *tlist, *tlist[1] = *(tlist+1)
	cout << "tlist[0]�� ���� " << tlist[0] << "�Դϴ�.\n";
	cout << "tlist[0]�� �ּҴ� " << &tlist[0] << "�Դϴ�.\n";
	cout << "tlist[1]�� ���� " << tlist[1] << "�Դϴ�.\n";
	cout << "tlist[1]�� �ּҴ� " << &tlist[1] << "�Դϴ�.\n";
	cout << "tlist+1�� ���� " << tlist+1 << "�Դϴ�.\n";
	cout << "tlist+1�� �ּҴ� " << tlist+1 << "�Դϴ�.\n";
	cout << "tlist�� ���� " << tlist << "�Դϴ�.\n";
	cout << "�� *tlist�� ���� " << *tlist << "�Դϴ�.\n"; // ù ��° �ε����� �����Ϳ� ��ġ��
	cout << "�� *(tlist+1)�� ���� " << *(tlist+1) << "�Դϴ�.\n";  

	/*
	int temp[num];

	cout << num << "���� ���������� �Է����ּ���.\n";
	for (int i=0; i < num; i++)
	{
		cin >> temp[i];
	}
	double ans = pavg(temp);
	cout << num << "���� ��� ������ " << ans << "���Դϴ�.\n";
	*/

	char str[6];
	str[0] = 'H';
	str[1] = 'e';
	str[2] = 'l';
	str[3] = 'l';
	str[4] = 'o';
	str[5] = '\0'; // null����

	//string str1 = "Hello";
	char cstr[6] = "Hello"; // ���� �迭�� ���ڿ��� �ʱ�ȭ�ϴ� ���� ����
	//str = "Hello"; // ���� �迭�� ���ڿ��� �����ϴ� ���� �Ұ�
	cout << str << "\n";
	
	int inum[3] = { 1,2,3 };
	cout << inum << "\n";

	char* pstr = "Hello";
	cout << "pstr = " << pstr << "\n";
	cout << "*pstr = " << *pstr << "\n";
	cout << "&pstr = " << &pstr << "\n";
	pstr = "World";
	pstr = str;
	cout << "pstr = " << pstr << "\n";
	cout << "*pstr = " << *pstr << "\n";
	cout << "&pstr = " << &pstr << "\n";

	/*
	cout << "�̸��� �Է��ϼ���.\n";
	cin >> str;
	cout << str << "\n";
	*/
	/*
	for (int i=0; str[i] != '\0'; i++)
	{
		cout << str[i] << "*";
	}
	*/

	/*
	char mstr[100];
	cout << "���ڿ�(������ �� ����)�� �Է��ϼ���. ������ �Է����� ������.\n";
	cin >> mstr;
	cout << "�Է��� ���ڿ��� ���̴� " << strlen(mstr) << "�Դϴ�.\n";
	*/

	char str0[20];
	char str1[10];
	char str2[10];

	strcpy_s(str1, "Hello");
	strcpy_s(str2, "GoodBye");
	strcpy_s(str0, str1);
	strcat_s(str0, str2);

	cout << "�迭 str1�� " << str1 << "�Դϴ�.\n";
	cout << "�迭 str2�� " << str2 << "�Դϴ�.\n";
	cout << "�����ϸ� " << str0 << "�Դϴ�.\n";

	char search[100];
	char ch;

	/*
	cout << "���ڿ��� �Է��ϼ���.\n";
	cin >> search;
	cout << "�˻��� ���ڸ� �Է��ϼ���.\n";
	cin >> ch;

	int c = count(search, ch);
	cout << search << " �ȿ� " << ch << " " << c << "���� �ֽ��ϴ�.\n";
	*/

	int nb = 1; // ��������

	cout << "���� �Լ����� ���� a�� b�� ����� �� �ֽ��ϴ�.\n";
	cout << "���� a�� ���� " << a << "�Դϴ�.\n";
	cout << "���� b�� ���� " << nb << "�Դϴ�.\n";

	func();

	for (int i=0; i < 5; i++)
	{
		func();
		cout << sa*2 - 1 << "\n";
		sa++;
	}

	int* pA1;
	pA1 = new int;

	cout << "�������� �޸𸮸� Ȯ���߽��ϴ�.\n";
	*pA1 = 10;
	cout << "*pA = " << *pA1 << "\n";

	delete pA1;
	cout << "Ȯ���� �޸𸮸� �����߽��ϴ�.\n";

	int mnum;
	int* pA2;

	cout << "�л� �� ���� ������ �Է��Ͻðڽ��ϱ�?\n";
	cin >> mnum;

	pA2 = new int[mnum];
	cout << mnum << "�� ���� ������ �Է��ϼ���.\n";

	for (int i = 0; i < mnum; i++)
	{
		cin >> pA2[i];
	}

	for (int i = 0; i < mnum; i++)
	{
		cout << i + 1 << "��° �л��� ������ " << pA2[i] << "�Դϴ�.\n";
	}

	delete[] pA2;
	cout << "Ȯ���� �޸𸮸� �����߽��ϴ�.\n";

	return 0;

}

double avg(int t[])
{
	double sum = 0.0;
	for (int i=0; i < num; i++)
	{
		sum += t[i];
	}
	
	return sum / num;
}

double pavg(int* pt)
{
	double sum = 0;

	for (int i=0; i < num; i++)
	{
		//sum += *(pt + i);
		sum += pt[i]; // �����Ͱ� �迭�� ����ų ������ �ε��� ��밡��
	}

	return sum / num;

}

void func()
{
	//�����Ѵ� == ���� ����
	static int na = 0; // ���� ����(���� ������ �Ӽ������� static�� Ȱ���ϸ� ������ �Ӽ��� ���´�)
	int sb = 2; // ���� ����

	/*
	cout << "func �Լ����� ���� a�� c�� ����� �� �ֽ��ϴ�.\n";
	cout << "���� a�� ���� " << a << "�Դϴ�.\n";
	cout << "���� c�� ���� " << c << "�Դϴ�.\n";
	*/
	cout << "a = " << sa << " b = " << sb <<  "\n";
	sa++; sb++;
}