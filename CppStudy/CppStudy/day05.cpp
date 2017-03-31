#include <iostream>
using namespace std;

enum Week { MON, TUE, WED, THU, FRI, SAT, SUN };

struct Car
{
	int num;
	double gas;
	void say();
};
void Car::say()
{
	cout << "������ȣ = " << num << " ���ᷮ = " << gas << "\n";
}

void show(Car *pC) //�� �����ڴ� ��ü�� ��밡���ϹǷ� ->�� �̿��Ѵ�
{
	cout << "������ȣ = " << pC->num << " ���ᷮ = " << pC->gas << "\n";
}

void rshow(Car &rC) //�� �����ڴ� ��ü�� ��밡���ϹǷ� ->�� �̿��Ѵ�
{
	cout << "������ȣ = " << rC.num << " ���ᷮ = " << rC.gas << "\n";
}

union Year
{
	int ad;
	int dangi;
};

// �⺻ Ŭ����
class Carcls : public Vehicle
{
protected:
	//private :
	int num;
	double gas;
public:
	//Carcls(); // ������
	Carcls(int n = 0, double g = 0.0);
	//Carcls(int n, double g);
	virtual void show();
	void setNumGas(int n, double g);
	int getNum() { return num; } // ����� ���Ǹ� ���÷� �ϹǷ� �����ݷ��� �ʿ����
	double getGas() { return gas; }

	// ���� �������
	static int sum;
	static void showSum();
};
/*
Carcls::Carcls()
{
	num = 0;
	gas = 0.0;
	cout << "�ڵ��� ����\n";
}
*/

Carcls::Carcls(int n, double g)
{
	num = n;
	gas = g;
	sum++;
	cout << "�ڵ��� ����\n";
}

void Carcls::show()
{
	cout << "������ȣ = " << num << " ��ⷮ = " << gas << "�Դϴ�.\n";
	//cout << "�ӵ��� " << speed << "�Դϴ�.\n";
};

void Carcls::setNumGas(int n, double g)
{
	if (g > 0 && g < 3000000)
	{
		num = n;
		gas = g;
	}
	else cout << g << "�� �ùٸ� ���� �ƴմϴ�.\n";
}

void Carcls::showSum()
{
	// ���� ��� �Լ����� �Ϲ� ��� ������ ���� �Ұ�
	cout << "�ڵ����� ��� " << sum << "�밡 ����������ϴ�.\n";
}

void buy(Carcls c)
{
	int n = c.getNum();
	double g = c.getGas();
	cout << "������ȣ = " << n << " ���ᷮ = " << g << " ����\n";
};

void pbuy(Carcls* pC)
{
	int n = pC->getNum();
	double g = pC->getGas();
	cout << "������ȣ = " << n << " ���ᷮ = " << g << " ����\n";
};

void rbuy(Carcls& rC)
{
	int n = rC.getNum();
	double g = rC.getGas();
	cout << "������ȣ = " << n << " ���ᷮ = " << g << " ����\n";
};

void test(Carcls c)
{
	c.setNumGas(1111, 30.5);
};

int Carcls::sum = 0;

// �Ļ� Ŭ����
class RacingCar : public Carcls, public RacingCar
{
private:
	int course;
public:
	RacingCar(int n = 0, double g = 0.0, int c = 1);
	void setCourse(int c);
	void newShow();
	void show();
};

RacingCar::RacingCar(int n, double g, int c) : Carcls(n, g)
{
	course = c;
	cout << "�ڽ���ȣ " << c << " ���̽� ī�� ����������ϴ�.\n";
}

void RacingCar::setCourse(int c)
{
	course = c;
	cout << "�ڽ� ��ȣ�� " << course << "�� �����Ͽ����ϴ�.\n";
}

void RacingCar::newShow()
{
	cout << "�ڵ����� ��� " << sum << "���� ����������ϴ�.\n";
}

void RacingCar::show()
{
	cout << "���̽�ī��ȣ = " << num << " ��ⷮ = " << gas << "�Դϴ�.\n";
	cout << "�ڽ� ��ȣ = " << course << "\n";
}

// �߻� Ŭ����
class Vehicle
{
protected :
	int speed;
public :
	void setSpeed(int s);
	virtual void show() = 0; // ���������Լ�
};

class Plane : public Vehicle
{
private :
	int flight;
public :
	Plane(int f);
	void show();
};

void Vehicle::setSpeed(int s)
{
	speed = s;
	cout << "�ӵ� = " << s << "\n";
}

Plane::Plane(int f)
{
	flight = f;
	cout << "����� ��ȣ�� " << flight << "�� ����Ⱑ ����������ϴ�.\n";
}

void Plane::show()
{
	cout << "������� ��ȣ�� " << flight << "�Դϴ�.\n";
	cout << "�ӵ��� " << speed << "�Դϴ�.\n";
}

int main()
{
	
	// ������

	// ����ü

	// ����ü

	Carcls::showSum();

	Carcls mcar1(1234, 25.5);
	RacingCar rCar(9876, 15.5, 3);

	mcar1.show();
	rCar.show();

	//Vehicle v1; // �߻� Ŭ������ ��ü�� ���� �� ����

	Vehicle* pV[2];
	Carcls* pCars[2];

	Carcls car1(1234, 20.5);
	RacingCar rCar1;
	rCar1.show();

	pCars[0] = &car1;
	pCars[0]->setNumGas(1234, 25.5);

	pCars[1] = &rCar;
	pCars[1]->setNumGas(5678, 40.5);

	for (int i = 0; i < 2; i++)
	{
		pCars[i]->show();
	}

	Plane pln1(5678);
	Carcls car2(1234, 20.5);

	pV[0] = &car2;
	pV[1] = &pln1;

	pV[0]->setSpeed(30);
	pV[1]->setSpeed(20);



	return 0;
}


