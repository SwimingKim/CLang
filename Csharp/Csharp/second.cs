using System;
using System.Threading;

namespace Csharp
{
	class Second
	{
		public static void Main (string[] args)
		{
			/*
			double inch;
			Console.WriteLine ("inch 값을 입력하세요");
			inch = double.Parse (Console.ReadLine ());
			Console.WriteLine ("cm으로 변환된 값 = "+inch*2.54);
			*/

			/*
			int num;
			Console.Write ("정수를 입력하세요 : ");
			num = int.Parse (Console.ReadLine ());
			if (num % 2 == 1) 
			{
				Console.WriteLine (num + " : 홀수");
			} 
			else 
			{
				Console.WriteLine (num + " : 짝수");
			}
			*/

			// 조건문 : if문
			if (DateTime.Now.Hour < 11) {
				Console.WriteLine ("아침 먹을 시간입니다.");
			} 
			else if (DateTime.Now.Hour < 15) 
			{
				Console.WriteLine ("점심 먹을 시간입니다.");
			} 
			else 
			{
				Console.WriteLine ("저녁 먹을 시간입니다.");
			}

			/*
			Console.Write ("정수를 입력하세요.");
			int input = int.Parse (Console.ReadLine ());
			switch (input % 2) {
			case 0:
				Console.WriteLine ("짝수입니다.");
				break;
			case 1:
				Console.WriteLine ("홀수입니다.");
				break;
			}
			*/

			/*
			Console.WriteLine ("지금은 몇 월입니까?");
			int month = int.Parse (Console.ReadLine ());
			switch (month) {
			case 3:
			case 4:
			case 5:
				Console.WriteLine ("봄입니다");
				break;
			case 6:
			case 7:
			case 8:
				Console.WriteLine ("여름입니다");
				break;
			case 9:
			case 10:
			case 11:
				Console.WriteLine ("가을입니다");
				break;
			case 12:
			case 1:
			case 2:
				Console.WriteLine ("겨울입니다.");
				break;
			default:
				Console.WriteLine ("지구가 아니군요");
				break;
			}
			*/

			// 삼항 연산자
			/*
			Console.WriteLine ("숫자를 입력해주세요.");
			int input = int.Parse (Console.ReadLine ());
			Console.WriteLine (input > 0 ? "자연수입니다." : "자연수가 아닙니다.");
			Console.WriteLine (input % 2 == 1 ? "자연수입니다." : "자연수가 아닙니다.");
			*/

			/*
			Console.WriteLine ("본인의 태어난 연도를 입력하세요.");
			int month = int.Parse (Console.ReadLine ());
			String str = "";

			switch (month%12) {
			case 0:
				str = "원숭이";
				break;
			case 1:
				str = "닭";
				break;
			case 2:
				str = "개";
				break;
			case 3:
				str = "돼지";
				break;
			case 4:
				str = "쥐";
				break;
			case 5:
				str = "소";
				break;
			case 6:
				str = "범";
				break;
			case 7:
				str = "토끼";
				break;
			case 8:
				str = "용";
				break;
			case 9:
				str = "뱀";
				break;
			case 10:
				str = "말";
				break;
			case 11:
				str = "양";
				break;
			}
			Console.WriteLine (str + "입니다.");
			*/

			/*
			Console.WriteLine ("문자열 입력 : ");
			string line = Console.ReadLine ();
			if (line.Contains ("안녕")) 
			{
				Console.WriteLine ("안녕하세요~~");
			} 
			else
			{
				Console.WriteLine ("*^-^*");
			}
			*/

			/*
			ConsoleKeyInfo info = Console.ReadKey ();
			switch (info.Key) {
			case ConsoleKey.LeftArrow:
				Console.WriteLine ("왼쪽으로 이동");
				break;
			case ConsoleKey.UpArrow:
				Console.WriteLine ("위쪽으로 이동");
				break;
			case ConsoleKey.RightArrow:
				Console.WriteLine ("오른쪽으로 이동");
				break;
			case ConsoleKey.DownArrow:
				Console.WriteLine ("아래쪽으로 이동");
				break;
			default:
				Console.WriteLine ("잘못된 키 조작입니다.");
				break;
			}
			*/

//			c++
//			int intArray[5] = { 52, 273, 32, 65, 103 };
			int[] intArray = { 52, 273, 32, 65, 103 };
			long[] longArray = { 52L, 273L, 32L, 65L, 103L };
			float[] floatArray = { 52.0f, 273.0f, 32.0f, 65.0f, 103.0f };
			double[] doubleArray = { 52.0, 273.0, 32.0, 65.0, 103.0 };
			char[] charArray = { '가', '나', '다', '라', '마' };
			string[] stringArray = { "윤인성", "연하진", "윤아린" };

			intArray [0] = 55;
			Console.WriteLine (intArray[0]);
			for (int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine (intArray[i]);
			}

			int[] array = new int[100];
			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine (array[i]);
			}

			/*
			int j = 0;
			while(j < intArray.Length)
			{
				Console.WriteLine (intArray[j]);
				j++;
			}
			*/


			/*
			string input;
			do {
				Console.WriteLine ("문자열　입력 (exit 입력시　종료）: ");
				input = Console.ReadLine ();
			} while(input != "exit");
			*/

			/*
			for (int i = '가'; i <= '힣'; i++) {
				Console.Write ((char)i);
			}
			Console.WriteLine("");
			*/

			/*
			long start = DateTime.Now.Ticks;
			long count = 0;
			while (start + 10000000 > DateTime.Now.Ticks)
			{
				count++;
			}
			Console.WriteLine (count + "만큼 반복했습니다.");

			foreach (var item in stringArray) {
				Console.WriteLine (item);
			}
			*/

			/*
			0	313		0001000
			1	232		0011100
			2	151		0111110
			3	070		1111111
			4	151		0111110
			5	232		0011100
			6	313		0001000
			*/

			/*
			Console.WriteLine ("숫자를 입력해주세요.");
			int star = int.Parse (Console.ReadLine ());
			Console.WriteLine (star);
			*/
			/*

			for (int i = 0; i < star; i++) {
				if (i == 0 || i == star - 1) {
					Console.Write ("---");
				} else if (i == 1 || i == star - 2) {
					Console.Write ("--");
				} else if (i == 2 || i == star - 3) {
					Console.Write ("-");
				} else if (i == 3 || i == star - 4) {
				}

				for (int j = 1; j <= i+1; j++) {
					int count = 0;
					if (j == 0 || j == star - 1) {
						count = 0;
					} else if (j == 1 || j == star - 2) {
						count = 1;
					} else if (j == 2 || j == star - 3) {
						count = 2;
					} else if (j == 3 || j == star - 4) {
						count = 3;
					}
					for (int k = 0; k < count; k++) {
						Console.Write ("*");
					}
				}
1
				if (i == 0 || i == star - 1) {
					Console.Write ("-");
					Console.Write ("-");
					Console.Write ("-");
				} else if (i == 1 || i == star - 2) {
					Console.Write ("-");
					Console.Write ("-");
				} else if (i == 2 || i == star - 3) {
					Console.Write ("-");
				} else if (i == 3 || i == star - 4) {
				}
				Console.WriteLine ("");
			}
			*/

			int star = 7;
			for (int i = 1; i <= star; i++) {
				if (i <= star / 2 + 1) {
					for (int j = star / 2 - (i - 1); j > 0; j--) {
						Console.Write ("-");
					}
					for (int j = 1; j <= i * 2 - 1; j++) {
						Console.Write ("*");
					}
					for (int j = star / 2 - (i - 1); j > 0; j--) {
						Console.Write ("-");
					}
				} else {
					for (int j = star/2 + 1; j < i; j++) {
						Console.Write ("-");
					}
					for (int j = star*2 - (i*2-1); j > 0; j--) {
						Console.Write ("*");
					}
					for (int j = star/2 + 1; j < i; j++) {
						Console.Write ("-");
					}
				}
				Console.WriteLine ("");
			}

			/*
			while (true) {
				Console.WriteLine ("홀수 입력 (짝수 입력 시 종료) : ");
				int input = int.Parse (Console.ReadLine ());
				if (input%2 == 0) {
					break;
				}
			}
			*/

			for (int i = 0; i < 10; i++) {
				if (i%5==0) {
					goto spc;
				}
				Console.WriteLine (i);
			}

			for (int i = 0; i < 10; i++) {
				if (i%2==0) {
					continue;
				}
				Console.WriteLine (i);
			}

			spc :
			Console.WriteLine ("goto처리");


			string input = "Potato Tomato";
			Console.WriteLine (input.ToUpper ());
			Console.WriteLine (input.ToLower ());

			string input1 = "Potata Tomato Banana";
//			string[] inputs = input1.Split (new char[] {' '});
//			string[] inputs = input1.Split (new string[] {" "}, 10, StringSplitOptions.None);
			string[] inputs = input1.Split (' ');
			foreach (var item in inputs) {
				Console.WriteLine (item);
			}

			string input2 = "    test     \n";
			Console.WriteLine ("::"+input2.Trim ()+"::");

			string[] array1 = {"Banana", "Tomato", "Potato"};
			Console.WriteLine (string.Join (", ", array1));

			/*
			int x = 1;
			while (x < 50) {
				Console.Clear ();
				Console.SetCursorPosition (x, 5);

				if (x % 3 == 0) {
					Console.WriteLine (" __0");
				} else if (x % 3 == 1) {
					Console.WriteLine (" _^@");
				} else {
					Console.WriteLine ("^_@");
				}

				Thread.Sleep (100);
				x++;
			}
			*/


			int x = 20;
			int y = 10;
			bool chk = true;

			while (true) {
				if (!chk) {
					break;
				}
				Console.Clear ();
				Console.SetCursorPosition (x, y);
				Console.CursorVisible = false;
				Console.WriteLine ("@");

				ConsoleKeyInfo mykey = Console.ReadKey ();
				switch (mykey.Key) {
				case ConsoleKey.UpArrow:
					y--;
					break;
				case ConsoleKey.DownArrow:
					y++;
					break;
				case ConsoleKey.LeftArrow:
					x--;
					break;
				case ConsoleKey.RightArrow:
					x++;
					break;
				case ConsoleKey.Escape:
					chk = false;
					break;
				}

			}






		}
	}
}

