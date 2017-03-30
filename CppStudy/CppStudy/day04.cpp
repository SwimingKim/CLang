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

int sa = 0; // 전역 변수

void func();

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

	/*
	cout << "이름음 입력하세요.\n";
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
	cout << "문자열(영문자 및 숫자)를 입력하세요. 공백은 입력하지 마세요.\n";
	cin >> mstr;
	cout << "입력한 문자열의 길이는 " << strlen(mstr) << "입니다.\n";
	*/

	char str0[20];
	char str1[10];
	char str2[10];

	strcpy_s(str1, "Hello");
	strcpy_s(str2, "GoodBye");
	strcpy_s(str0, str1);
	strcat_s(str0, str2);

	cout << "배열 str1은 " << str1 << "입니다.\n";
	cout << "배열 str2는 " << str2 << "입니다.\n";
	cout << "연결하면 " << str0 << "입니다.\n";

	char search[100];
	char ch;

	/*
	cout << "문자열을 입력하세요.\n";
	cin >> search;
	cout << "검색할 문자를 입력하세요.\n";
	cin >> ch;

	int c = count(search, ch);
	cout << search << " 안에 " << ch << " " << c << "개가 있습니다.\n";
	*/

	int nb = 1; // 지역변수

	cout << "메인 함수에서 변수 a와 b를 사용할 수 있습니다.\n";
	cout << "변수 a의 값은 " << a << "입니다.\n";
	cout << "변수 b의 값은 " << nb << "입니다.\n";

	func();

	for (int i=0; i < 5; i++)
	{
		func();
		cout << sa*2 - 1 << "\n";
		sa++;
	}

	int* pA1;
	pA1 = new int;

	cout << "동적으로 메모리를 확보했습니다.\n";
	*pA1 = 10;
	cout << "*pA = " << *pA1 << "\n";

	delete pA1;
	cout << "확보한 메모리를 해제했습니다.\n";

	int mnum;
	int* pA2;

	cout << "학생 몇 명의 점수를 입력하시겠습니까?\n";
	cin >> mnum;

	pA2 = new int[mnum];
	cout << mnum << "명 분의 점수를 입력하세요.\n";

	for (int i = 0; i < mnum; i++)
	{
		cin >> pA2[i];
	}

	for (int i = 0; i < mnum; i++)
	{
		cout << i + 1 << "번째 학생의 점수는 " << pA2[i] << "입니다.\n";
	}

	delete[] pA2;
	cout << "확보한 메모리를 해제했습니다.\n";

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

void func()
{
	//지정한다 == 지역 변수
	static int na = 0; // 정적 변수(전역 변수의 속성이지만 static를 활용하면 정적인 속성을 갖는다)
	int sb = 2; // 지역 변수

	/*
	cout << "func 함수에서 변수 a와 c를 사용할 수 있습니다.\n";
	cout << "변수 a의 값은 " << a << "입니다.\n";
	cout << "변수 c의 값은 " << c << "입니다.\n";
	*/
	cout << "a = " << sa << " b = " << sb <<  "\n";
	sa++; sb++;
}