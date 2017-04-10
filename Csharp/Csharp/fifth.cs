using System;
using System.Collections.Generic;

namespace Csharp
{
	class Wanted<T>
	{
		public T Value;
		public Wanted(T v)
		{
			this.Value = v;
		}
	}

	class Test<T, U> 
		where T : class 
		where U : struct 
	{
		public T Value1;
		public U Value2;
	}

	class Square
	{
		public int num;
		public int this [int i] {
			get	
			{
				return i*i;			
			}
			set
			{
				this.num = i;
				Console.WriteLine (i + "번째 상품 설정");
			}
		}
	}

	struct Point
	{
		public int x;
		public int y;
		public string pA;
		public string pB;
		public Test tt;
//		public string pB = "imsi"; // 생성자에서 초기화를 해야 함
		public Point(int x, int y, string s1, string s2) // 구조체의 생성자는 모든 변수를 초기화해야 함
		{
			this.x = x;
			this.y = y;
			this.pA = s1;
			this.pB = s2;
			this.tt = null;
		}
	}

	class Test
	{
		public int x;
		public int y;
		public Test()
		{
		}
		public Test(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
	}

	class Product : IComparable
	{
		public string Name {
			get;
			set;
		}

		public int Price {
			get;
			set;
		}

		public int CompareTo(object obj)
		{
			return -(Price.CompareTo ((obj as Product).Price));
//			return Price.CompareTo ((obj as Product).Price);
//			return Name.CompareTo ((obj as Product).Name);
//			throw new NotImplementedException ();
		}

		public override string ToString()
		{
//			return base.ToString ();
			return Name + " : " + Price;
		}

	}

	class Test1
	{
		public int num;
		public string str = "abc";
	}

	interface IBasic
	{
		int TestInstanceMethod ();
		int TestProperty {
			get	;
			set;
		}
	}

	interface IBasicA
	{
		int TestProperty {
			get	;
			set;
		}
	}

	class CBasic : IBasic
	{
		public int TestProperty {
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int TestInstanceMethod()
		{
			throw new NotImplementedException ();
		}
	}

	/*
	class Parent
	{
	}

	class Child : Parent, IBasic, IDisposable, IComparable
	{
	}
	*/

	class Temp : IBasic, IBasicA
	{
		public int TestProperty {
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		int IBasic.TestInstanceMethod()
		{
			throw new NotImplementedException ();
		}

		public int TestInstanceMethod()
		{
			throw new NotImplementedException ();
		}
	}

	public class fifth
	{
		static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
		{
			rx = x + vx;
			ry = y + vy;
		}

		public static void Main(string[] args)
		{
			Wanted<string> wString = new Wanted<string>("String");
			Wanted<int> wInt = new Wanted<int>(52273);
			Wanted<double> wDouble = new Wanted<double>(52.273);

			Console.WriteLine (wString.Value);
			Console.WriteLine (wInt.Value);
			Console.WriteLine (wDouble.Value);

			Square sqr = new Square ();
			Console.WriteLine (sqr[10]);
			Console.WriteLine (sqr[20]);
			Console.WriteLine (sqr[30]);
			sqr [100] = 123;

			/*
			Console.WriteLine ("정수 입력 = ");
			int output;
			bool result = int.TryParse (Console.ReadLine (), out output);

//			if (int.TryParse (Console.ReadLine (), out output))
			if (result)
			{
				Console.WriteLine ("입력한 정수 = "+output);
			} 
			else
			{
				Console.WriteLine ("정수를 입력하세요.");	
			}
			*/

			int x = 0;
			int y = 0;
			int vx = 1;
			int vy = 1;
			Console.WriteLine ("현재 좌표 = "+x+" , "+y);
			NextPosition (x, y, vx, vy, out x, out y);
			Console.WriteLine ("다음 좌표 = "+x+" , "+y);

			Point pp;
			Point pp1 = new Point();
//			Point pp2 = new Point(10, 20);
			pp.x = 10; // 초기화해주지 않으면 오류
			pp.x = 20;
//			Console.WriteLine (pp.x); // 값 복사
//			Console.WriteLine (pp.y);

			Test cp = new Test ();
			Test cp1;
			Test cp2 = new Test (10, 20); // 참조 복사
			Console.WriteLine (cp.x); 
			Console.WriteLine (cp.y);

			List<Product> pList = new List<Product> () {
				new Product () { Name = "Potato", Price = 1500 },
				new Product () { Name = "Tomato", Price = 2400 },
				new Product () { Name = "Banana", Price = 1000 },
				new Product () { Name = "Apple", Price = 3000 },
			};

			pList.Sort ();
			foreach (var item in pList) {
				Console.WriteLine (item);
//				Console.WriteLine (item.Name + " : " + item.Price);
			}

			List<Test1> tt = new List<Test1> () {
				new Test1() { num = 10, str = "aaa"},
				new Test1() { num = 20, str = "bbb"},
				new Test1() { num = 30, str = "ccc"},
			};

			foreach (var item in tt) {
				Console.WriteLine (tt);
			}


//			IBasic bb = new IBasic ();
			IBasic bb = new CBasic ();

			/*
			Child ch0 = new Child ();
			Parent ch1 = new Child ();
			IBasic ch2 = new Child ();
			IDisposable ch3 = new Child ();
			IComparable ch4 = new Child ();
			*/

			/*
			Console.WriteLine ("정수 입력 = ");

			try {
				int input = int.Parse (Console.ReadLine ());
				Console.WriteLine ("입력 값 = "+input);
			} catch (Exception ex) {
				Console.WriteLine ("예외가 발생했습니다");
				Console.WriteLine (ex.GetType ());
				Console.WriteLine (ex.Message);
				Console.WriteLine (ex.StackTrace);
				goto TheEnd;
			} finally {
				Console.WriteLine ("프로그램이 종료되었습니다");
			}

			TheEnd:
				Console.WriteLine ("End!!");
			*/

			/*
			string[] array = { "abc", "def" };
			if (int.TryParse (Console.ReadLine (), out input)) {
				if (input < array.Length) {
					Console.WriteLine ("입력한 배열 값 = "+array[input]);
				} else {
					Console.WriteLine ("인덱스 범위를 넘었습니다");
				}
			} else {
				Console.WriteLine ("정수를 입력하세요");
			}
			*/

			Console.WriteLine ("입력 = ");

			try {
				string input = Console.ReadLine ();
				int[] array = { 52, 273, 32, 103 };
				int index = int.Parse (input);
				Console.WriteLine ("입력 숫자 = "+index);
				Console.WriteLine ("배열 요소 = "+array[index]);
			} catch (Exception ex) {
				Console.WriteLine ("FormatException 발생");
				Console.WriteLine (ex.GetType ()+" 발생");
			}


		}

	}
}

