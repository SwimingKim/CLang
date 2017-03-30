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

int main()
{
	// 포인터
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

	// 레퍼런스
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
		cout << i + 1 << "번째 사람의 점수는 " << test[i] << "입니다.\n";
 	}

	/*
	const int num = 5;
	int list[num];
	cout << num << "명의 점수를 입력하세요.\n";
	for (int i=0; i < num; i++)
	{
		cin >> test[i];
	}
	for (int i = 0; i < num; i++)
	{
		cout << i << "번째 사람의 점수는 " << test[i] << "입니다.\n";
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
		cout << i + 1 << "등의 점수는 " << test[i] << "입니다.\n";
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
	int mlist[x][y] = { // 앞 인덱스인 x는 생략이 가능하다
		{80, 60, 22, 50, 75},
		{90, 55, 68, 72, 58},
	};

	for (int i=0; i<num; i++)
	{
		cout << i + 1 << "번째 학생의 국어점수는 " << mlist[0][i] << "입니다.\n";
		cout << i + 1 << "번째 학생의 수학점수는 " << mlist[1][i] << "입니다.\n";
	}

	int tlist[5] = { 80, 60, 55, 22, 75 };
	// *tlist[0] = *tlist, *tlist[1] = *(tlist+1)
	cout << "tlist[0]의 값은 " << tlist[0] << "입니다.\n";
	cout << "tlist[0]의 주소는 " << &tlist[0] << "입니다.\n";
	cout << "tlist[1]의 값은 " << tlist[1] << "입니다.\n";
	cout << "tlist[1]의 주소는 " << &tlist[1] << "입니다.\n";
	cout << "tlist+1의 값은 " << tlist+1 << "입니다.\n";
	cout << "tlist+1의 주소는 " << tlist+1 << "입니다.\n";
	cout << "tlist의 값은 " << tlist << "입니다.\n";
	cout << "즉 *tlist의 값은 " << *tlist << "입니다.\n"; // 첫 번째 인덱스의 포인터에 위치함
	cout << "즉 *(tlist+1)의 값은 " << *(tlist+1) << "입니다.\n";  

	/*
	int temp[num];

	cout << num << "명의 시험점수를 입력해주세요.\n";
	for (int i=0; i < num; i++)
	{
		cin >> temp[i];
	}
	double ans = pavg(temp);
	cout << num << "명의 평균 점수는 " << ans << "점입니다.\n";
	*/

	char str[6];
	str[0] = 'H';
	str[1] = 'e';
	str[2] = 'l';
	str[3] = 'l';
	str[4] = 'o';
	str[5] = '\0'; // null문자

	//string str1 = "Hello";
	char cstr[6] = "Hello"; // 문자 배열을 문자열로 초기화하는 것은 가능
	//str = "Hello"; // 문자 배열에 문자열을 대입하는 것은 불가
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

	cout << "이름음 입력하세요.\n";
	cin >> str;
	cout << str << "\n";

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
		sum += pt[i]; // 포인터가 배열을 가리킬 때에만 인덱스 사용가능
	}

	return sum / num;

}