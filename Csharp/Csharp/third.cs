using System;
using System.Collections.Generic;

namespace Csharp
{
	class xxx
	{
		
	}

	public class third
	{
		class yyy 
		{
			class zzz 
			{
			}
		}

		class Product 
		{
			public static int counter = 0;
			public int id;
			public string name;
			public int price;
			public static double margin = 0.3; // 클래스 변수
			// 생성자에 static을 붙이면 일반 변수에서는 생성할 수 없다
			public Product()
			{
				Product.counter += 1;
				id = counter;
			}
			public Product(string n, int p)
			{
				Product.counter += 1;
				this.id = counter;
				this.name = n;
				this.price = p;
			}
		}

		class Test
		{
			public int Power(int x)
			{
				return x * x;
			}
			public int Multi(int x, int y)
			{
				return x * y;
			}
			public int Sum(int min, int max)
			{
				int output = 0;
				for (int i = min; i < max; i++) {
					output += i;
				}
				return output;
			}
			public static int Abs(int input)
			{
				if (input < 0)
					return -input;
				else
					return input;
			}
			public static double Abs(double input)
			{
				if (input < 0)
					return -input;
				else
					return input;
			}
			public static long Abs(long input)
			{
				if (input < 0)
					return -input;
				else
					return input;
			}		
		}

		public static void Main(string[] args) {
			
			int[] intArray = new int[5];
			/*
			Console.WriteLine ("5개의 정수를 입력해주세요");
			for (int i = 0; i < intArray.Length; i++) {
				intArray [i] = int.Parse (Console.ReadLine ());
			}
			*/
			/*
			int min = intArray[0], max = intArray[0];
			for (int i = 1; i < intArray.Length; i++) {
				if (intArray[i] < min) {
					min = intArray[i];
				} else if (intArray[i] > max) {
					max = intArray[i];
				}
			}
			Console.WriteLine ("max = " + max + " min = " + min);
			*/

			for (int i = 0; i < intArray.Length - 1; i++) {
				for (int j = i + 1; j < intArray.Length; j++) {
					int tmp;
					if (intArray[i] < intArray[j]) {
						tmp = intArray [i];
						intArray [i] = intArray [j];
						intArray [j] = tmp;
					}
				}
			}
			Console.WriteLine ("min = " + intArray[intArray.Length - 1] + " max = " + intArray[0]);

			Random _random = new Random ();

			Console.WriteLine (_random.Next (10, 100));
			Console.WriteLine (_random.NextDouble ()*1000);


			List<int> mlist = new List<int> ();
			List<int> mlist2 = new List<int>{ 1, 2, 3, 4, 5 };
			mlist.Add (52);
			mlist.Add (273);
			mlist.Add (32);
			mlist.Add (64);
			foreach (var item in mlist) {
				Console.WriteLine ("Count : " + mlist.Count + "\titem : " + item);
			}

			mlist.RemoveAt (0);
			mlist.Remove (32);
			foreach (var item in mlist) {
				Console.WriteLine ("Count : " + mlist.Count + "\titem : " + item);
			}

			Console.WriteLine (Math.Abs (-52234)); // 절대값
			Console.WriteLine (Math.Ceiling (52.234)); //올림
			Console.WriteLine (Math.Floor (52.234)); //버림
			Console.WriteLine (Math.Round (52.234)); //반올림
			Console.WriteLine (Math.Max (52, 234));
			Console.WriteLine (Math.Min (52, 234));

			Product pro1 = new Product ();
			pro1.name = "Potato";
			pro1.price = 2000;

			Console.WriteLine (pro1.name + " : " + pro1.price);

			Product pro2 = new Product () { name = "Potato", price = 3000 };
			Product pro3 = new Product () { name = "Banana", price = 4000 };

			Console.WriteLine (Product.margin);

			List<Product> pList = new List<Product> ();
			pList.Add (new Product(){name = "Potato", price = 1000});
			pList.Add (new Product(){name = "Tomato", price = 500});
			pList.Add (new Product(){name = "Banana", price = 500});
			pList.Add (new Product(){name = "Carrot", price = 3000});

			/*
			foreach (var item in pList) {
				if (item.price > 500) {
					pList.Remove (item);
				}
			}
			*/

			/*
			for (int i = 0; i < pList.Count; i++) {
//				Console.WriteLine (i+" : "+pList.Count+" : "+pList[i].name);
				if (pList[i].price > 500) {
//					pList.Remove (pList[i]);
					pList.RemoveAt (i);
				}
			}
			*/

			for (int i = pList.Count - 1; i >= 0; i--) {
				if (pList[i].price > 500) {
					pList.RemoveAt (i);
				}
			}

			foreach (var item in pList) {
				Console.WriteLine (item.name + " : " + item.price);
			}

			/*
			int num = _random.Next (10, 100);
			Console.WriteLine ("정답 = "+num);

			int count = 1, user = 0;
			while (count <= 10) {
				Console.WriteLine ("라운드 " + count + " : 10 ~ 99 숫자를 맞춰주세요.");
				user = int.Parse (Console.ReadLine ());
				if (user > num) {
					Console.WriteLine ("Down");
				} else if (user < num) {
					Console.WriteLine ("Up");
				} else {
					Console.WriteLine ("정답입니다!!");
					break;
				}
				count++;
			}

			if (num != user) {
				Console.WriteLine ("오답입니다!! 정답은 "+num+"입니다.");
			}
			*/

			Test tt = new Test ();
			Console.WriteLine (tt.Power (10));
			Console.WriteLine (tt.Power (20));

			Console.WriteLine (tt.Multi (10, 20));
			Console.WriteLine (tt.Multi (52, 273));

			Console.WriteLine (tt.Sum (10, 100));

			Console.WriteLine (Test.Abs (52));
			Console.WriteLine (Test.Abs (-273));
			Console.WriteLine (Test.Abs (-12.253));
			Console.WriteLine (Test.Abs (-2.121173));

			Product mpro1 = new Product("Potato", 2000);
			Product mpro2 = new Product("Tomato", 3000);
			Product mpro3 = new Product (){ name = "Banana", price = 4000 };

			Console.WriteLine (mpro1.id + " : " + mpro1.name + " : " + mpro1.price);
			Console.WriteLine (mpro2.id + " : " + mpro2.name + " : " + mpro2.price);
			Console.WriteLine (mpro3.id + " : " + mpro3.name + " : " + mpro3.price);


		
		}
	}
}

