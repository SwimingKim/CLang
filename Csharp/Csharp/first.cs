using System;

namespace Csharp
{
	public class first
	{
		public static void Main(string[] args)
		{

			Console.Write("Hello");
			Console.WriteLine("World..!");
			// 나머지 연산의 부호는 좌항에 달려 있다
			Console.WriteLine(5.0 % 2.2);
			Console.WriteLine("가\\나\\다" + "라마바");
			Console.WriteLine("안녕하세요"[0]);
			Console.WriteLine("안녕");
			Console.WriteLine('힣' - '가');
			Console.WriteLine(true);
			Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);

			int a = 273;
			long b = 52;
			Console.WriteLine(a+b);
			Console.WriteLine(a-b);
			Console.WriteLine(a*b);
			Console.WriteLine(a%b);
			Console.WriteLine(a/b);

			Console.WriteLine("int : " + sizeof(int));
			Console.WriteLine("long : " + sizeof(long));
			Console.WriteLine("float : " + sizeof(float));
			Console.WriteLine("double : " + sizeof(double));
			Console.WriteLine("char : " + sizeof(char));

			string message = "안녕하세요";

			Console.WriteLine(message+"!");
			Console.WriteLine(message+1234);
			Console.WriteLine(message[0]);

			bool ba = 10 < 0;
			bool bb = 20 < 100;

			Console.WriteLine(ba);
			Console.WriteLine(bb);

			string output = "Hello";
			output += "World";
			Console.WriteLine(output);

			int num = 10;
			Console.WriteLine(num);
			Console.WriteLine(num++);
			Console.WriteLine(num--);
			Console.WriteLine(num);

			int num1 = 10;
			num++;
			Console.WriteLine(num1);
			Console.WriteLine(++num1);
			Console.WriteLine(--num1);
			Console.WriteLine(num1);

			int _int = 273;
			long _long = 52232788;
			float _float = 52.273f;
			double _double = 52.273;
			char _char = '글';
			string _string = "문자열";

			Console.WriteLine(_int.GetType());
			Console.WriteLine(_long.GetType());
			Console.WriteLine(_float.GetType());
			Console.WriteLine(_double.GetType());
			Console.WriteLine(_char.GetType());
			Console.WriteLine(_string.GetType());

			// var형 변수는 선언과 동시에 초기화해야 함
			// var형 변수는 지역 변수
			var mynum = 100;
			Console.WriteLine(mynum.GetType());

			/*
			string input = Console.ReadLine();
			Console.WriteLine("input = " + input);
			*/

			long lNum = 213131231 + 2312131231;
			int iNUm = (int)lNum; //자료형의 강제변환(데이터 손실의 우려가 있음)
			Console.WriteLine(iNUm);

			//자료형의 자동변환(데이터의 손실의 우려가 있음)

			string numToString = "52245";
			int iNum2 = int.Parse(numToString);
			Console.WriteLine(iNum2);

			/*
			int input = int.Parse(Console.ReadLine());
			input++;
			Console.WriteLine("input = " + input);
			*/

			double dnum = 52.273;
			string st = dnum + "";
			Console.WriteLine(st);
			st = dnum.ToString("0.0000");
			Console.WriteLine(st);

			Console.WriteLine(bool.Parse("true"));
			Console.WriteLine(bool.Parse("false"));

		}
	}
}
