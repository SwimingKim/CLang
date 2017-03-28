#include <iostream>
using namespace std;

int main() 
{
	/*
	자료형

	논리형 : bool(1byte)
	문자형 : char, unsigned char(1byte)
	정수형 : int
	실수형 : float(4byte), double(8byte)
	int num;
	int num1 = 0;
	int num2;

	char ck;
	double dA, dB;

	num = 1;
	num = 3.14;
	dA = 3.14;

	num2 = 10;
	num2 = num1;

	cout << num1*num2+dA << '\n';
	cout << num << '\n' ;
	*/

	/*
	사용자의 입력받기
	int num1, num2;
	cout << "정수를 2개 입력 : \n";

	cin >> num1 >> num2;

	cout << num1 << " & " << num2 << " 입력되었습니다.\n";

	*/

	/*
	상수
	const double pi = 3.141592;
	//pi = 3.14;
	cout << "원주율의 값은 " << pi << " 입니다.\n";
	
	cout << "1 + 2 = " << 1 + 2 << " 입니다.\n";
	cout << "3 + 4 = " << 3 * 4 << " 입니다.\n\n";
	*/

	/*
	int num1, num2;

	cout << "첫번째 정수 : \n";
	cin >> num1;
	cout << "두번째 정수 : \n";
	cin >> num2;

	int sum = num1 + num2;

	cout << "변수 num1의 값은 " << num1 << "입니다.\n";
	cout << "변수 num2의 값은 " << num2 << "입니다.\n";
	cout << "변수 num1 + num2의 값은 " << sum << "입니다.\n\n";

	num1 += 1;
	//sum = num1 + num2;

	cout << "변수 num1의 값은 " << num1 << "입니다.\n";
	cout << "변수 num2의 값은 " << num2 << "입니다.\n";
	cout << "변수 num1 + num2의 값은 " << sum << "입니다.\n";
	cout << "변수 num1 + num2의 값은 " << num1+num2 << "입니다.\n\n";
	*/

	/*
	연산자
	int num1 = 5;
	int num2 = 10;

	cout << "num2 + num1 = " << num2 + num1 << "입니다.\n";
	cout << "num2 - num1 = " << num2 - num1 << "입니다.\n";
	cout << "num2 * num1 = " << num2 * num1 << "입니다.\n";
	cout << "num2 / num1 = " << num2 / num1 << "입니다.\n";
	cout << "num2 % num1 = " << num2 % num1 << "입니다.\n";
	*/

	/*
	전위/후위 증가 연산자
	int num1 = 0;
	int num2 = 0;

	num2 = num1++;
	cout << "num1의 값은 (후위 증가 연산자) : " << num1 << "입니다.\n";
	cout << "num2의 값은 (후위 증가 연산자) : " << num2 << "입니다.\n";

	num2 = ++num1;
	cout << "num1의 값은 (전위 증가 연산자) : " << num1 << "입니다.\n";
	cout << "num2의 값은 (전위 증가 연산자) : " << num2 << "입니다.\n";
	*/

	/*
	int sum = 0;
	int num = 0;

	cout << "첫 번째 정수 : \n";
	cin >> num;
	sum += num;

	cout << "두 번째 정수 : \n";
	cin >> num;
	sum += num;

	cout << "세 번째 정수 : \n";
	cin >> num;
	sum += num;

	cout << num << "\n";
	cout << "세 정수의 합은 " << sum << "입니다\n";
	*/

	/*
	int a = 5;
	int b = 0;

	cout << "short int 형의 크기는 " << sizeof(short int) << "바이트입니다.\n";
	cout << "int 형의 크기는 " << sizeof(int) << "바이트입니다.\n";
	cout << "long int 형의 크기는 " << sizeof(long int) << "바이트입니다.\n";
	cout << "float 형의 크기는 " << sizeof(float) << "바이트입니다.\n";
	cout << "double 형의 크기는 " << sizeof(double) << "바이트입니다.\n";
	cout << "long double 형의 크기는 " << sizeof(long double) << "바이트입니다.\n";
	cout << "변수 a 의 크기는 " << sizeof(a) << "바이트입니다.\n";
	cout << "변수 a + b 의 크기는 " << sizeof(a+b) << "바이트입니다.\n";
	b = a << 2;
	cout << "식 a << 2 의 크기는 " << b << "입니다.\n";
	cout << 0 + 1 * 5 << "입니다.\n";
	*/

	/*
	int r = 3;
	const double pi = 3.14;

	cout << "반지름이 " << r << "인 원의 \n";
	cout << "둘레는 " << r * 2 * pi << "이고,\n";
	cout << "넓이는 " << r * r * pi << "입니다.\n";
	*/
	
	/*
	int num1 = 5;
	int num2 = 4;
	double div = (double)num1 / num2;

	cout << "5 / 4 = " << div << "\n";
	*/

	/*
	float heigth, weight;
	cout << "삼각형의 밑변을 입력해주세요.\n";
	cin >> heigth;
	cout << "삼각형의 높이를 입력해주세요.\n";
	cin >> weight;
	cout << "삼각형의 넓이는 " << heigth*weight / 2 << "입니다.\n";
	*/

	/*
	int sum = 0, num = 0;
	cout << "제1과목의 점수를 입력해주세요.\n";
	cin >> num; sum += num;
	cout << "제2과목의 점수를 입력해주세요.\n";
	cin >> num; sum += num;
	cout << "제3과목의 점수를 입력해주세요.\n";
	cin >> num; sum += num;
	cout << "제4과목의 점수를 입력해주세요.\n";
	cin >> num; sum += num;
	cout << "제5과목의 점수를 입력해주세요.\n";
	cin >> num; sum += num;

	cout << "총점 = " << sum << "\t평균 = " << (float)sum/5 << "\n";
	*/

	/*
	int res;
	cout << "정수를 입력하세요.\n";
	cin >> res;

	//if (res == 1) cout << "1이 입력되었습니다.\n";
	if (res == 1)
	{
		cout << "1이 입력되었습니다.\n";
		cout << "1이 선택하였습니다.\n";
	}
	else if (res == 2) 
		cout << "2가 입력되었습니다.\n";
	else cout << "1과 2 이외의 값이 입력되었습니다.\n";

	cout << "처리를 종료합니다.\n";
	*/

	/*
	int res;
	cout << "정수를 입력하세요.\n";
	cin >> res;

	switch (res)
	{
		case 1: 
			cout << "1이 입력되었습니다.\n";
			break;
		case 2:
			cout << "2가 입력되었습니다.\n";
			break;
		case 3:
			cout << "3이 입력되었습니다.\n";
			break;

		default:
			cout << "1, 2, 3 중 하나를 입력하세요.\n";
	}
	*/

	/*
	char res;
	cout << "당신은 학생입니까?\n";
	cout << "Y 또는 y를 입력하세요.\n";
	cin >> res;

	if (res == 'Y' || res == 'y') 
	{
		cout << "당신은 학생입니다.\n";
	}
	else cout << "당신은 학생이 아닙니다.\n";
	*/

	/* 
	int res;
	char ans;
	cout << "몇 번째 코스를 선택하시겠습니까?\n(1번 : A코스 / 2번 : B코스)\n";
	cin >> res;

	//if (res == 1) ans = 'A';
	//else ans = 'B';

	ans = (res == 1) ? 'A' : 'B';
	cout << ans << "코스를 선택했습니다.\n";
	*/
	
	/*
	int num;
	cout << "몇 번을 반복하시겠습니까?\n";
	cin >> num;


	for (int i = 1; i <= num; i++) 
	{
		cout << i << "번째 반복하고 있습니다.\n";
	}
	cout << num << "번 반복이 끝났습니다.\n";
	*/

/*
	int num;
	int sum = 0;

	cout << "숫자 몇까지의 합을 구하시겠습니까?\n";
	cin >> num;

//	for (int i = 0; i <= num; i++) 
//	{
//		sum += i;
//	}

	int i = 0;
	while (i <= num) 
	{
		sum += i;
		i++;
	}
	cout << "0부터 " << num << "까지의 합계는 " << sum << "입니다.\n";
*/

	/*
	int num = 1;
	while (num)
	{
		cout << "정수를 입력하세요. ('0'을 입력하면 종료됩니다.)\n";
		cin >> num;
		cout << num << " 이(가) 입력되었습니다.";
	}
	cout << "반복이 종료되었습니다.\n";
	*/
	
	/*
	int num = 1;
	do
	{
		cout << "정수를 입력하세요. ('1'을 입력하면 종료됩니다.)\n";
		cin >> num;
		cout << num << " 이(가) 입력되었습니다.";
	} while (!num);
	cout << "반복이 종료되었습니다.\n";
	*/

	/*
	int ch = 0;
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			if (ch == 0) 
			{
				cout << "*"; ch = 1;
			}
			else
			{
				cout << "-"; ch = 0;
			}
		}
		cout << "\n";
	}
	*/
	
	/*
	int res;
	cout << "몇 번째 반복에서 루프를 빠져나가겠습니까? (1~10)\n";
	cin >> res;

	for (int i = 1; i < 10; i++)
	{
		cout << i << "번째 처리입니다.\n";
		if (i == res) break;
	}
	*/

	int res;
	cout << "몇 번째 반복에서 건너 뛰시겠습니까? (1~10)\n";
	cin >> res;

	for (int i = 1; i < 10; i++)
	{
		if (i == res) continue;
		cout << i << "번째 처리입니다.\n";
	}

	return 0;
}