#include <iostream>
using namespace std;

void buy(int num, int money) 
{
	for (int i = 0; i < num; i++)
	{
		cout << money << "만원인 차를 구입했습니다.\n";
	}
}

// 함수의 프로토타입 선언
int sumCar(int cost1 = 1000, int cost2 = 1200);
// default argument (기본 인수) : 오른쪽부터 입력해야 한다
float tempFunc(float a, float b = 100)
{
	return a + b;
}
// tempFunc()로 불러오기 가능
int tempFunc(int a = 200, int b = 100)
{
	return a + b;
}

// 오버로딩
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

// 레퍼런스에 의한 교환
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
	cout << "해당 수보다 작은 짝수를 구합니다. 정수를 입력해주세요.\n";
	cin >> num;

	for (int i = 0; i <= num; i++)
	{
		if (i % 2 == 0)
			cout << i << "\n" ;
	}
	*/

	/*
	int star;
	cout << "별을 출력합니다. 정수를 입력해주세요.\n";
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
	cout << "별을 출력합니다. 정수를 입력해주세요.\n";
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
	cout << "별을 출력합니다. 정수를 입력해주세요.\n";
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
	cout << "별을 출력합니다. 정수를 입력해주세요.\n";
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
	cout << "돈을 많이 벌었습니다.\n";

	int cost1, cost2;
	cout << "첫 번째 차량의 구입가는 얼마입니까?\n";
	cin >> cost1;
	buy(1, cost1);

	cout << "두 번째 차량의 구입가는 얼마입니까?\n";
	cin >> cost2;
	buy(1, cost2);

	int sum = cost1 + cost2;
	//cout << "결국 구입한 차량의 총 금액은 " << sum << "입니다.\n";
	cout << "결국 구입한 차량의 총 금액은 " << sumCar(cost1, cost2) << "입니다.\n";
	*/

	/*
	int num1, num2, ans;

	cout << "첫 번째 정수 입력 : \n";
	cin >> num1;

	cout << "두 번째 정수 입력 : \n";
	cin >> num2;

	ans = max(num1, num2);
	cout << "두 수 중 큰 수는 " << ans << "입니다.\n";
	*/

	int a = tempFunc();
	cout << a << "입니다.\n";

	/*
	int a, b;
	double dA, dB;

	cout << "정수 2개를 입력하세요.\n";
	cin >> a >> b;

	cout << "실수 2개를 입력하세요.\n";
	cin >> dA >> dB;

	int ans1 = maxt(a, b);
	double ans2 = maxt(dA, dB);

	cout << "입력받은 두 정수 중 큰 수는 " << ans1 << "입니다.\n";
	cout << "입력받은 두 실수 중 큰 수는 " << ans2 << "입니다.\n";
	*/

	/*
	float num;
	cout << "제곱을 구할 수를 입력해주세요.\n";
	cin >> num;

	cout << num << "의 제곱은 " << sqr(num) << "입니다.\n";
	cout << num << "의 제곱은 " << sqrl(num) <<"입니다.\n";
	*/

	// 포인터 변수
	int na, nb;
	int* pA; // int *pA과 동일
	/*
	int* pA, pB; // 포인터 pA와 int pB 생성
	int *pA, *pB; // 포인터 pA와 포인터 pB 생성
	int* pA;
	int* pB;
	// pNum == &5
	// *pNum == 5
	*/

	na = 5;
	nb = 10;
	pA = &na;
	cout << "변수 a의 값은 " << na << "입니다.\n";
	cout << "변수 a의 주소는 " << &na << "입니다.\n";
	cout << "*pA의 값은 " << *pA << "입니다.\n";
	cout << "포인터 pA의 값은 " << pA << "입니다.\n";

	pA = &nb;
	cout << "변수 b의 값은 " << nb << "입니다.\n";
	cout << "변수 b의 주소는 " << &nb << "입니다.\n";
	cout << "*pA의 값은 " << *pA << "입니다.\n";
	cout << "포인터 pA의 값은 " << pA << "입니다.\n";
	
	*pA = 30;
	cout << "변수 b의 값은 " << nb << "입니다.\n";
	cout << "변수 b의 주소는 " << &nb << "입니다.\n";
	cout << "*pA의 값은 " << *pA << "입니다.\n";
	cout << "포인터 pA의 값은 " << pA << "입니다.\n";

	int num1 = 5;
	int num2 = 10;

	cout << "num1  : " << num1 << "\n";
	cout << "num2  : " << num2 << "\n";
	cout << "num1과 num2를 교환합니다.\n";

	swap(num1, num2);
	cout << "num1  : " << num1 << "\n";
	cout << "num2  : " << num2 << "\n"; 5;
	

	int newa = 5;
	int& rA = newa;

	cout << "변수 a의 값은 " << newa << "입니다.\n";
	cout << "레퍼런스 rA의 값은 " << rA << "입니다.\n";

	rA = 50;
	cout << "rA에 50을 대입했습니다.\n";
	cout << "변수 a의 값은 " << newa << "입니다.\n";
	cout << "레퍼런스 rA의 값은 " << rA << "입니다.\n";
	cout << "변수 a의 주소는 " << &newa << "입니다.\n";
	cout << "레퍼런스 rA의 주소는 " << &rA << "입니다.\n";

	return 0;
}

int sumCar(int cost1, int cost2)
{
	int sum = cost1 + cost2;

	return cost1 + cost2;
}




