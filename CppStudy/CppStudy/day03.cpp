#include <iostream>
using namespace std;

void buy(int num, int money) 
{
	for (int i = 0; i < num; i++)
	{
		cout << money << "������ ���� �����߽��ϴ�.\n";
	}
}

// �Լ��� ������Ÿ�� ����
int sumCar(int cost1 = 1000, int cost2 = 1200);
// default argument (�⺻ �μ�) : �����ʺ��� �Է��ؾ� �Ѵ�
float tempFunc(float a, float b = 100)
{
	return a + b;
}
// tempFunc()�� �ҷ����� ����
int tempFunc(int a = 200, int b = 100)
{
	return a + b;
}

// �����ε�
inline int max(int x, int y) { if (x > y) return x; else return y; }
float max(float x, float y) { if (x > y) return x; else return y; }

template <class T>
//template <typename T>

T maxt(T x, T y)
{
	if (x > y) return x;
	else return y;
}

int sqr(int num)
{
	return num*num;
}

float sqr(float num)
{
	return num*num;
}

template <class L>
L sqrl (L num)
{
	return num*num;
}

/*
void swap(int* pX, int* pY)
{
	int temp;
	temp = *pX;
	*pX = *pY;
	*pY = temp;
}
*/

// ���۷����� ���� ��ȯ
void swap(int& rX, int& rY)
{
	int temp;
	temp = rX;
	rX = rY;
	rY = temp;
}

int main() 
{
	/*
	int num;
	cout << "�ش� ������ ���� ¦���� ���մϴ�. ������ �Է����ּ���.\n";
	cin >> num;

	for (int i = 0; i <= num; i++)
	{
		if (i % 2 == 0)
			cout << i << "\n" ;
	}
	*/

	/*
	int star;
	cout << "���� ����մϴ�. ������ �Է����ּ���.\n";
	cin >> star;

	for (int i = 0; i < star; i++)
	{
		for (int j = 0; j <= i; j++) 
		{
			cout << "*" ;
		}
		cout << "\n";
	}
	*/

	/*
	int star;
	cout << "���� ����մϴ�. ������ �Է����ּ���.\n";
	cin >> star;

	for (int i = 0; i < star; i++)
	{
		//for (int j = star; j >= 0; j--)
		//{
		//	if (j <= i) cout << "*";
		//	else cout << " ";
		//}

		//for (int j = 0; j <= star; j++) 
		//{
		//	if (j < star - i) cout << " ";
		//	else cout << "*";
		//}

		for (int j = star-i; j > 0; j--)
		{
			if (j != 1) cout << ' ';
		}
		for (int j = 0; j <= i; j++)
		{
			cout << "*";
		}
		cout << "\n";
	}
	*/

	/*
	int star;
	cout << "���� ����մϴ�. ������ �Է����ּ���.\n";
	cin >> star;

	for (int i = 0; i < star; i++)
	{
		for (int j = star-1; j >= 0; j--)
		{
			if (j < i) cout << "*";
			else if (j != i) cout << " ";
		}
		for (int j = 0; j <= i; j++)
		{
			cout << "*";
		}
		cout << "\n";
	}
	*/

	/*
	int star;
	cout << "���� ����մϴ�. ������ �Է����ּ���.\n";
	cin >> star;

	for (int i = 1; i <= star; i++)
	{
		for (int j = star - i; j > 0; j--)
		{
			cout << ' ';
		}
		for (int j = 0; j < i*2 - 1; j++)
		{
			cout << "*";
		}
		cout << "\n";
	}
	*/

	/*
	cout << "���� ���� �������ϴ�.\n";

	int cost1, cost2;
	cout << "ù ��° ������ ���԰��� ���Դϱ�?\n";
	cin >> cost1;
	buy(1, cost1);

	cout << "�� ��° ������ ���԰��� ���Դϱ�?\n";
	cin >> cost2;
	buy(1, cost2);

	int sum = cost1 + cost2;
	//cout << "�ᱹ ������ ������ �� �ݾ��� " << sum << "�Դϴ�.\n";
	cout << "�ᱹ ������ ������ �� �ݾ��� " << sumCar(cost1, cost2) << "�Դϴ�.\n";
	*/

	/*
	int num1, num2, ans;

	cout << "ù ��° ���� �Է� : \n";
	cin >> num1;

	cout << "�� ��° ���� �Է� : \n";
	cin >> num2;

	ans = max(num1, num2);
	cout << "�� �� �� ū ���� " << ans << "�Դϴ�.\n";
	*/

	int a = tempFunc();
	cout << a << "�Դϴ�.\n";

	/*
	int a, b;
	double dA, dB;

	cout << "���� 2���� �Է��ϼ���.\n";
	cin >> a >> b;

	cout << "�Ǽ� 2���� �Է��ϼ���.\n";
	cin >> dA >> dB;

	int ans1 = maxt(a, b);
	double ans2 = maxt(dA, dB);

	cout << "�Է¹��� �� ���� �� ū ���� " << ans1 << "�Դϴ�.\n";
	cout << "�Է¹��� �� �Ǽ� �� ū ���� " << ans2 << "�Դϴ�.\n";
	*/

	/*
	float num;
	cout << "������ ���� ���� �Է����ּ���.\n";
	cin >> num;

	cout << num << "�� ������ " << sqr(num) << "�Դϴ�.\n";
	cout << num << "�� ������ " << sqrl(num) <<"�Դϴ�.\n";
	*/

	// ������ ����
	int na, nb;
	int* pA; // int *pA�� ����
	/*
	int* pA, pB; // ������ pA�� int pB ����
	int *pA, *pB; // ������ pA�� ������ pB ����
	int* pA;
	int* pB;
	// pNum == &5
	// *pNum == 5
	*/

	na = 5;
	nb = 10;
	pA = &na;
	cout << "���� a�� ���� " << na << "�Դϴ�.\n";
	cout << "���� a�� �ּҴ� " << &na << "�Դϴ�.\n";
	cout << "*pA�� ���� " << *pA << "�Դϴ�.\n";
	cout << "������ pA�� ���� " << pA << "�Դϴ�.\n";

	pA = &nb;
	cout << "���� b�� ���� " << nb << "�Դϴ�.\n";
	cout << "���� b�� �ּҴ� " << &nb << "�Դϴ�.\n";
	cout << "*pA�� ���� " << *pA << "�Դϴ�.\n";
	cout << "������ pA�� ���� " << pA << "�Դϴ�.\n";
	
	*pA = 30;
	cout << "���� b�� ���� " << nb << "�Դϴ�.\n";
	cout << "���� b�� �ּҴ� " << &nb << "�Դϴ�.\n";
	cout << "*pA�� ���� " << *pA << "�Դϴ�.\n";
	cout << "������ pA�� ���� " << pA << "�Դϴ�.\n";

	int num1 = 5;
	int num2 = 10;

	cout << "num1  : " << num1 << "\n";
	cout << "num2  : " << num2 << "\n";
	cout << "num1�� num2�� ��ȯ�մϴ�.\n";

	swap(num1, num2);
	cout << "num1  : " << num1 << "\n";
	cout << "num2  : " << num2 << "\n"; 5;
	

	int newa = 5;
	int& rA = newa;

	cout << "���� a�� ���� " << newa << "�Դϴ�.\n";
	cout << "���۷��� rA�� ���� " << rA << "�Դϴ�.\n";

	rA = 50;
	cout << "rA�� 50�� �����߽��ϴ�.\n";
	cout << "���� a�� ���� " << newa << "�Դϴ�.\n";
	cout << "���۷��� rA�� ���� " << rA << "�Դϴ�.\n";
	cout << "���� a�� �ּҴ� " << &newa << "�Դϴ�.\n";
	cout << "���۷��� rA�� �ּҴ� " << &rA << "�Դϴ�.\n";

	return 0;
}

int sumCar(int cost1, int cost2)
{
	int sum = cost1 + cost2;

	return cost1 + cost2;
}




