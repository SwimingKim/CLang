using System;

namespace Csharp
{
	class Program
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
		}
	}
}
