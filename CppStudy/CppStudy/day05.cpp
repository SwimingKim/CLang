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
	cout << "차량번호 = " << num << " 연료량 = " << gas << "\n";
}

void show(Car *pC) //닷 연산자는 객체만 사용가능하므로 ->를 이용한다
{
	cout << "차량번호 = " << pC->num << " 연료량 = " << pC->gas << "\n";
}

void rshow(Car &rC) //닷 연산자는 객체만 사용가능하므로 ->를 이용한다
{
	cout << "차량번호 = " << rC.num << " 연료량 = " << rC.gas << "\n";
}

union Year
{
	int ad;
	int dangi;
};

// 기본 클래스
class Carcls : public Vehicle
{
protected:
	//private :
	int num;
	double gas;
public:
	//Carcls(); // 생성자
	Carcls(int n = 0, double g = 0.0);
	//Carcls(int n, double g);
	virtual void show();
	void setNumGas(int n, double g);
	int getNum() { return num; } // 선언과 정의를 동시로 하므로 세미콜론이 필요없다
	double getGas() { return gas; }

	// 정적 멤버변수
	static int sum;
	static void showSum();
};
/*
Carcls::Carcls()
{
	num = 0;
	gas = 0.0;
	cout << "자동차 제조\n";
}
*/

Carcls::Carcls(int n, double g)
{
	num = n;
	gas = g;
	sum++;
	cout << "자동차 제조\n";
}

void Carcls::show()
{
	cout << "차량번호 = " << num << " 배기량 = " << gas << "입니다.\n";
	//cout << "속도는 " << speed << "입니다.\n";
};

void Carcls::setNumGas(int n, double g)
{
	if (g > 0 && g < 3000000)
	{
		num = n;
		gas = g;
	}
	else cout << g << "는 올바른 값이 아닙니다.\n";
}

void Carcls::showSum()
{
	// 정적 멤버 함수에서 일반 멤버 변수에 접근 불가
	cout << "자동차는 모두 " << sum << "대가 만들어졌습니다.\n";
}

void buy(Carcls c)
{
	int n = c.getNum();
	double g = c.getGas();
	cout << "차량번호 = " << n << " 연료량 = " << g << " 구매\n";
};

void pbuy(Carcls* pC)
{
	int n = pC->getNum();
	double g = pC->getGas();
	cout << "차량번호 = " << n << " 연료량 = " << g << " 구매\n";
};

void rbuy(Carcls& rC)
{
	int n = rC.getNum();
	double g = rC.getGas();
	cout << "차량번호 = " << n << " 연료량 = " << g << " 구매\n";
};

void test(Carcls c)
{
	c.setNumGas(1111, 30.5);
};

int Carcls::sum = 0;

// 파생 클래스
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
	cout << "코스번호 " << c << " 레이싱 카가 만들어졌습니다.\n";
}

void RacingCar::setCourse(int c)
{
	course = c;
	cout << "코스 번호를 " << course << "로 변경하였습니다.\n";
}

void RacingCar::newShow()
{
	cout << "자동차는 모두 " << sum << "개가 만들어졌습니다.\n";
}

void RacingCar::show()
{
	cout << "레이싱카번호 = " << num << " 배기량 = " << gas << "입니다.\n";
	cout << "코스 번호 = " << course << "\n";
}

// 추상 클래스
class Vehicle
{
protected :
	int speed;
public :
	void setSpeed(int s);
	virtual void show() = 0; // 순수가상함수
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
	cout << "속도 = " << s << "\n";
}

Plane::Plane(int f)
{
	flight = f;
	cout << "비행기 번호가 " << flight << "인 비행기가 만들어졌습니다.\n";
}

void Plane::show()
{
	cout << "비행기의 번호는 " << flight << "입니다.\n";
	cout << "속도는 " << speed << "입니다.\n";
}

int main()
{
	
	// 열거형

	// 구조체

	// 공용체

	Carcls::showSum();

	Carcls mcar1(1234, 25.5);
	RacingCar rCar(9876, 15.5, 3);

	mcar1.show();
	rCar.show();

	//Vehicle v1; // 추상 클래스는 객체를 만들 수 없음

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


