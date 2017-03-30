# C계열 언어 공부  


1. C  
2. C++  

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



3. C# for Unity  
4. C# for Xamarine
