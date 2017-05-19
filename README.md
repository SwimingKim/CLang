# C계열 언어 공부  


(1) C  


- 기본형태

```
#include <stdio.h>
main()
{
}
```


(2) C++  


  - 기본 형태  

```
#include <iostream>  
using namespace std;  
int main()  
{  
  return 0;  
}
```

  - 조건문  

```
if (condition)  
{  
}

switch (key)  
{  
  case value:
    break;
}  
```

  - 반복문  

```
for (int i=0; i < length)  
{  
}

while (condition)  
{  
}  

do  
{  
} while (condition)
```

  - 함수

```
int mfunc(int a, int b)
{
  return a + b;
}
template <class T>
T maxt(T x, T y)
{
  if(x > y) return x;
  else return y;
}
```

- 포인터

```
void swap(int* pA, int* pB)
{
  int temp = *pA;
  *pA = *pB;
  *pB = temp;
}

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
```

- 레퍼런스

```
void swap(int& rA, int& rB)
{
  int temp = rA;
  rA = rB;
  rB = temp;
}

int a = 5, b = 10;
int& rA = a;
cout << "rA = " << rA << " a = " << a << "\n";
cout << "&rA " << &rA << " &a = " << &a << "\n";
rswap(rA, a);
cout << "rA = " << rA << " a = " << a << "\n";
cout << "&rA = " << &rA << " &a = " << &a << "\n";
a = b;
cout << "&rA = " << &rA << " &a = " << &a << "\n";
```

- 배열

```
int list[5] = {1,2,3,4,5};
char str[6] = "Hello";
cout << str; // Hello
char* pstr = "World";
cout << pstr; // World;
```

- 열거체, 구조체, 공용체

```
enum Week = {SUN, MON, TUE, WED, THU, FRI, SAT, SUN};

struct Car
{
  string color;
  int gas;
};

union Markdet
{
  int buy;
  int sell;
};
```

- 클래스

```
class Car
{
  private:
    string color;
    int gas;
  public :
    Car()
    string getColor() { return color };
    int getGas() { return gas };
    void setColorGas(string c, int g);
};

Car::Car()
{
  color = '검정';
  gas = 10000;
  cout << "자동차 제조\n";
}

void Car::setColorGas(string c, int g)
{
  color = c;
  gas = g;
};
```

(3) C# for Unity  

- 기본자료형

```
int, long, float, double
char, string
bool

Int.Parse("123");

```

- 입력과 출력

```
Console.WriteLine("테스트입니다");
var user = Console.ReadLine();
```

- 조건문

```
if (true)
{

}
else if (false)
{

}
else
{

}

switche (num)
{
  case 0 :
    break;
  case 1 :
    break;
  default :
    break;
}
```

- 반복문

```
while(true)
{

}
do
{

} while (true)

for (int i = 0; i < 1000; i++)
{

}
string[] array = {"사과", "배", "포도", "딸기", "바나나"}
foreach (string item in array)
{

}
```

- 클래스

```
class Box
{
  private int width;
  public int Width
  {
    get
    {
      return width;
    }
    set
    {
      if (value < 0) { width = value; }
    }
  }

  private int height;
  public int Height
  {
    get
    {
      return height;
    }
    set
    {
      if (value > 0) { height = value; }
    }
  }

  public Box(int width, int height)
  {
      this.width = width;
      this.height = height;
  }

  public int Area()
  {
    return this.width * this.height
  }
}

```

- 상속

```
class Parent
{
  public Parent()
  {
    Console.WriteLine("부모생성자");
  }
}

class Child : Parent
{
  publib Child() : base()
  {
    Console.WriteLine("자식생성자");
  }
}

```

- 하이딩

```
class Parent
{
  public void Method() {}
}

class Child : Parent
{
  public new void Method() {}
}
```

- 오버라이딩

```
class Parent
{
  public virtual void Method() {}
}
class Child : Parent
{
  public override void Method() {}
}

abstract class Parent
{
  public abstract void Method() {}
}
class Child : Parent
{
  public override void Method() {}
}
```

- 구조체

```
struct Point
{
  public int mp;
  public string name;

  public Point(int mp)
  {
    this.mp = mp;
    this.name = "포인트";
  }
}
```

- 인터페이스

```
class Product : IComparable
{
  public int Price{ get; set; }

  public override string ToString()
  {
    return Price+"원";
  }
  public int CompareTo(object obj)
  {
    return this.Price.CompareTo((obj as Product).Price);
  }
}

```

- 델리게이터, 람다

```
List<Product> products = new List<Product>()
{
  new Product() {Price = 500},
  new Product() {Price = 200},
  new Product() {Price = 800},
};


// 델리게이터
products.Sort(SortWithPrice);
static int SortWithPrice(Product a, Product b)
{
  return a.Price.CompareTo(b.Price);
}

// 무명 델리게이터
products.Sort(delegate(Product a, Product b)
{
  return a.Price.CompareTo(b.Price);
});

// 람다
products.Sort((a,b)=>
{
  return a.Price.CompareTo(b.Price);
});
```

(4) C# for Xamarine
