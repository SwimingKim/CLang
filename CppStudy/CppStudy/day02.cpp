#include <iostream>
using namespace std;

int main() 
{
	/*
	�ڷ���

	���� : bool(1byte)
	������ : char, unsigned char(1byte)
	������ : int
	�Ǽ��� : float(4byte), double(8byte)
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
	������� �Է¹ޱ�
	int num1, num2;
	cout << "������ 2�� �Է� : \n";

	cin >> num1 >> num2;

	cout << num1 << " & " << num2 << " �ԷµǾ����ϴ�.\n";

	*/

	/*
	���
	const double pi = 3.141592;
	//pi = 3.14;
	cout << "�������� ���� " << pi << " �Դϴ�.\n";
	
	cout << "1 + 2 = " << 1 + 2 << " �Դϴ�.\n";
	cout << "3 + 4 = " << 3 * 4 << " �Դϴ�.\n\n";
	*/

	/*
	int num1, num2;

	cout << "ù��° ���� : \n";
	cin >> num1;
	cout << "�ι�° ���� : \n";
	cin >> num2;

	int sum = num1 + num2;

	cout << "���� num1�� ���� " << num1 << "�Դϴ�.\n";
	cout << "���� num2�� ���� " << num2 << "�Դϴ�.\n";
	cout << "���� num1 + num2�� ���� " << sum << "�Դϴ�.\n\n";

	num1 += 1;
	//sum = num1 + num2;

	cout << "���� num1�� ���� " << num1 << "�Դϴ�.\n";
	cout << "���� num2�� ���� " << num2 << "�Դϴ�.\n";
	cout << "���� num1 + num2�� ���� " << sum << "�Դϴ�.\n";
	cout << "���� num1 + num2�� ���� " << num1+num2 << "�Դϴ�.\n\n";
	*/

	/*
	������
	int num1 = 5;
	int num2 = 10;

	cout << "num2 + num1 = " << num2 + num1 << "�Դϴ�.\n";
	cout << "num2 - num1 = " << num2 - num1 << "�Դϴ�.\n";
	cout << "num2 * num1 = " << num2 * num1 << "�Դϴ�.\n";
	cout << "num2 / num1 = " << num2 / num1 << "�Դϴ�.\n";
	cout << "num2 % num1 = " << num2 % num1 << "�Դϴ�.\n";
	*/

	/*
	����/���� ���� ������
	int num1 = 0;
	int num2 = 0;

	num2 = num1++;
	cout << "num1�� ���� (���� ���� ������) : " << num1 << "�Դϴ�.\n";
	cout << "num2�� ���� (���� ���� ������) : " << num2 << "�Դϴ�.\n";

	num2 = ++num1;
	cout << "num1�� ���� (���� ���� ������) : " << num1 << "�Դϴ�.\n";
	cout << "num2�� ���� (���� ���� ������) : " << num2 << "�Դϴ�.\n";
	*/

	/*
	int sum = 0;
	int num = 0;

	cout << "ù ��° ���� : \n";
	cin >> num;
	sum += num;

	cout << "�� ��° ���� : \n";
	cin >> num;
	sum += num;

	cout << "�� ��° ���� : \n";
	cin >> num;
	sum += num;

	cout << num << "\n";
	cout << "�� ������ ���� " << sum << "�Դϴ�\n";
	*/

	/*
	int a = 5;
	int b = 0;

	cout << "short int ���� ũ��� " << sizeof(short int) << "����Ʈ�Դϴ�.\n";
	cout << "int ���� ũ��� " << sizeof(int) << "����Ʈ�Դϴ�.\n";
	cout << "long int ���� ũ��� " << sizeof(long int) << "����Ʈ�Դϴ�.\n";
	cout << "float ���� ũ��� " << sizeof(float) << "����Ʈ�Դϴ�.\n";
	cout << "double ���� ũ��� " << sizeof(double) << "����Ʈ�Դϴ�.\n";
	cout << "long double ���� ũ��� " << sizeof(long double) << "����Ʈ�Դϴ�.\n";
	cout << "���� a �� ũ��� " << sizeof(a) << "����Ʈ�Դϴ�.\n";
	cout << "���� a + b �� ũ��� " << sizeof(a+b) << "����Ʈ�Դϴ�.\n";
	b = a << 2;
	cout << "�� a << 2 �� ũ��� " << b << "�Դϴ�.\n";
	cout << 0 + 1 * 5 << "�Դϴ�.\n";
	*/

	/*
	int r = 3;
	const double pi = 3.14;

	cout << "�������� " << r << "�� ���� \n";
	cout << "�ѷ��� " << r * 2 * pi << "�̰�,\n";
	cout << "���̴� " << r * r * pi << "�Դϴ�.\n";
	*/
	
	/*
	int num1 = 5;
	int num2 = 4;
	double div = (double)num1 / num2;

	cout << "5 / 4 = " << div << "\n";
	*/

	/*
	float heigth, weight;
	cout << "�ﰢ���� �غ��� �Է����ּ���.\n";
	cin >> heigth;
	cout << "�ﰢ���� ���̸� �Է����ּ���.\n";
	cin >> weight;
	cout << "�ﰢ���� ���̴� " << heigth*weight / 2 << "�Դϴ�.\n";
	*/

	/*
	int sum = 0, num = 0;
	cout << "��1������ ������ �Է����ּ���.\n";
	cin >> num; sum += num;
	cout << "��2������ ������ �Է����ּ���.\n";
	cin >> num; sum += num;
	cout << "��3������ ������ �Է����ּ���.\n";
	cin >> num; sum += num;
	cout << "��4������ ������ �Է����ּ���.\n";
	cin >> num; sum += num;
	cout << "��5������ ������ �Է����ּ���.\n";
	cin >> num; sum += num;

	cout << "���� = " << sum << "\t��� = " << (float)sum/5 << "\n";
	*/

	/*
	int res;
	cout << "������ �Է��ϼ���.\n";
	cin >> res;

	//if (res == 1) cout << "1�� �ԷµǾ����ϴ�.\n";
	if (res == 1)
	{
		cout << "1�� �ԷµǾ����ϴ�.\n";
		cout << "1�� �����Ͽ����ϴ�.\n";
	}
	else if (res == 2) 
		cout << "2�� �ԷµǾ����ϴ�.\n";
	else cout << "1�� 2 �̿��� ���� �ԷµǾ����ϴ�.\n";

	cout << "ó���� �����մϴ�.\n";
	*/

	/*
	int res;
	cout << "������ �Է��ϼ���.\n";
	cin >> res;

	switch (res)
	{
		case 1: 
			cout << "1�� �ԷµǾ����ϴ�.\n";
			break;
		case 2:
			cout << "2�� �ԷµǾ����ϴ�.\n";
			break;
		case 3:
			cout << "3�� �ԷµǾ����ϴ�.\n";
			break;

		default:
			cout << "1, 2, 3 �� �ϳ��� �Է��ϼ���.\n";
	}
	*/

	/*
	char res;
	cout << "����� �л��Դϱ�?\n";
	cout << "Y �Ǵ� y�� �Է��ϼ���.\n";
	cin >> res;

	if (res == 'Y' || res == 'y') 
	{
		cout << "����� �л��Դϴ�.\n";
	}
	else cout << "����� �л��� �ƴմϴ�.\n";
	*/

	/* 
	int res;
	char ans;
	cout << "�� ��° �ڽ��� �����Ͻðڽ��ϱ�?\n(1�� : A�ڽ� / 2�� : B�ڽ�)\n";
	cin >> res;

	//if (res == 1) ans = 'A';
	//else ans = 'B';

	ans = (res == 1) ? 'A' : 'B';
	cout << ans << "�ڽ��� �����߽��ϴ�.\n";
	*/
	
	/*
	int num;
	cout << "�� ���� �ݺ��Ͻðڽ��ϱ�?\n";
	cin >> num;


	for (int i = 1; i <= num; i++) 
	{
		cout << i << "��° �ݺ��ϰ� �ֽ��ϴ�.\n";
	}
	cout << num << "�� �ݺ��� �������ϴ�.\n";
	*/

/*
	int num;
	int sum = 0;

	cout << "���� ������� ���� ���Ͻðڽ��ϱ�?\n";
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
	cout << "0���� " << num << "������ �հ�� " << sum << "�Դϴ�.\n";
*/

	/*
	int num = 1;
	while (num)
	{
		cout << "������ �Է��ϼ���. ('0'�� �Է��ϸ� ����˴ϴ�.)\n";
		cin >> num;
		cout << num << " ��(��) �ԷµǾ����ϴ�.";
	}
	cout << "�ݺ��� ����Ǿ����ϴ�.\n";
	*/
	
	/*
	int num = 1;
	do
	{
		cout << "������ �Է��ϼ���. ('1'�� �Է��ϸ� ����˴ϴ�.)\n";
		cin >> num;
		cout << num << " ��(��) �ԷµǾ����ϴ�.";
	} while (!num);
	cout << "�ݺ��� ����Ǿ����ϴ�.\n";
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
	cout << "�� ��° �ݺ����� ������ ���������ڽ��ϱ�? (1~10)\n";
	cin >> res;

	for (int i = 1; i < 10; i++)
	{
		cout << i << "��° ó���Դϴ�.\n";
		if (i == res) break;
	}
	*/

	int res;
	cout << "�� ��° �ݺ����� �ǳ� �ٽðڽ��ϱ�? (1~10)\n";
	cin >> res;

	for (int i = 1; i < 10; i++)
	{
		if (i == res) continue;
		cout << i << "��° ó���Դϴ�.\n";
	}

	return 0;
}