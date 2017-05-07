using System;
using System.Collections.Generic;

namespace Csharp
{
	public class Sixth_second
	{
		class Car
		{
			public int Num { get; set; }
			public double Gas { get; set; }

			public Car(int n, double g)
			{
				this.Num = n;
				this.Gas = g;
			}

			public override string ToString()
			{
				return "번호 = " + this.Num + " 연료량 = " + this.Gas;
			}

		}

		class Cars
		{
			private List<Car> listOfCar = new List<Car>();
			public delegate void PrintProcess(Car cha);
			public void Add(Car car1)
			{
				listOfCar.Add(car1);
			}

			public void Print()
			{
				// PrintProcess(PrintWithoutParameter);
			}

			public void Print(PrintProcess process)
			{
				foreach (var item in listOfCar)
				{
					process(item);
				}
			}

			static void PrintWithoutParameter(Car car1)
			{
				Console.WriteLine(car1);
			}
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Test");

			Cars carA = new Cars();
			carA.Add(new Car(1234, 25.5));
			carA.Add(new Car(5678, 45.5));

			carA.Print();
			carA.Print(PrintWithoutParameter);
			

		}

		static void PrintWithoutParameter(Car car1)
		{
			Console.WriteLine();
			Console.WriteLine("이름 = "+car1.Num);
			Console.WriteLine("연료량 = "+car1.Gas);
		}

	}
}
