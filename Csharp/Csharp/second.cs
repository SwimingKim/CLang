using System;

namespace Csharp
{
	class Second
	{
		public static void Main (string[] args)
		{
			double inch;
			Console.WriteLine ("inch 값을 입력하세요");
			inch = double.Parse (Console.ReadLine ());
			Console.WriteLine ("cm으로 변환된 값 = "+inch*2.54);
		}
	}
}

