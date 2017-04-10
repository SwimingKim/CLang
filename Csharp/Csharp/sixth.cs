using System;
using System.Collections.Generic;

namespace Csharp
{
	public class sixth
	{
		public delegate void TestDelegateA();

		class Box
		{
			private int width;
			public int Width
			{
				get { return width; }
				set
				{
					if (value > 0) { width = value; }
					else { throw new Exception("너비는 자연수를 입력하세요."); }
				}
			}

			private int height;
			public int Height
			{
				get { return height; }
				set
				{
					if (value > 0) { height = value; }
					else { throw new Exception("높이는 자연수를 입력하세요."); }
				}
			}

			public Box(int w, int h)
			{
				Width = w;
				Height = h;
			}

			public int Area()
			{
				return this.width * this.height;
			}

		}

		class CustomException : Exception
		{

			public CustomException(string message) : base(message)
			{

			}

		}

		class Product
		{
			public string Name
			{
				get;
				set;
			}

			public int Price
			{
				get;
				set;
			}
		}

		public delegate void TestDelegateB();

		class Student
		{
			public string Name { get; set; }
			public double Score { get; set; }

			public Student(string n, double s)
			{
				this.Name = n;
				this.Score = s;
			}

			public override string ToString()
			{
				return this.Name + " : " + this.Score;
			}

		}

		class Students
		{
			private List<Student> listOfStudent = new List<Student>();
			public delegate void PrintProcess(Student list);
			// public delegate void PrintWithoutParameter();
			public void Add(Student std)
			{
				listOfStudent.Add(std);
			}
			
			public void Print()
			{
				// PrintWithoutParameter();

				Print((std) => {
					Console.WriteLine(std);
				});

				// Print(delegate(String std){
				// 	Console.WriteLine(std);
				// });
			}

			public void Print(PrintProcess process)
			{
				foreach (var item in listOfStudent)
				{
					process(item);
				}
			}

			static void PrintWithParameter(Student std)
			{
				Console.WriteLine(std);
			}
		}

		public static void Main(string[] args)
		{
			//throw new Exception(); // 즉시 멈춘다

			/*
			try
			{
				throw new Exception();
			}
			catch (Exception ex)
			{
				Console.WriteLine("예외가 발생했습니다.");
			}
			*/

			Box bb = new Box(10, 20);
			Console.WriteLine(bb.Area());

			try
			{
				throw new CustomException("사용자 정의 예외");
			}
			catch (CustomException ex)
			{
				Console.WriteLine(ex.Message);
			}

			List<Product> prod = new List<Product>()
			{
				new Product() { Name = "Potato", Price = 500 },
				new Product() { Name = "Tomato", Price = 700 },
				new Product() { Name = "Banana", Price = 400 },
				new Product() { Name = "Apple", Price = 600 },
				new Product() { Name = "Cherry", Price = 500 }
			};

			// 정렬
			//prod.Sort(); // IComparision 인터페이스가 필요함
			//prod.Sort(SortWithPrice); // SortWithPrice 델리게이트 이용
			prod.Sort(delegate(Product a, Product b) // 무명 델리게이터를 이용
			{
				return a.Price.CompareTo(b.Price);
			});
			prod.Sort((a, b) => // 람다함수
			{
				return a.Name.CompareTo(b.Name);
			});
			prod.Sort((a, b) => a.Price.CompareTo(b.Price));


			// 출력
			foreach (var item in prod)
			{
				Console.WriteLine(item.Name + " : " + item.Price);
			}

			TestDelegateA deleA = TestDeleMethod; // 초기화시 () 사용안함 
			TestDelegateA deleB = delegate () { }; // 무명 델리게이터
			TestDelegateA deleC = () => { }; // 람다

            deleA();
            deleB();
			deleC();

			Students student1 = new Students();
			student1.Add(new Student("홍길동", 4.2));
			student1.Add(new Student("사임당", 4.2));

			student1.Print();
			/*
			student1.Print((std) => {
				Console.WriteLine();
				Console.WriteLine("이름 : " + std.Name);
				Console.WriteLine("점수 : " + std.Score);
			});
 			*/

			 student1.Print(delegate(Student std){ // 무명 델리게이트
				Console.WriteLine();
				Console.WriteLine("이름 : " + std.Name);
				Console.WriteLine("점수 : " + std.Score);
			 });

			 student1.Print(PrintWithParameter);




		}

		/*
		static int SortWithPrice(Product a, Product b) {
			return a.Price.CompareTo(b.Price);
			//return -(a.Price.CompareTo(b.Price)); // 가격 내림차순
		}
		*/

		static void PrintWithParameter(Student std) 
		{
				Console.WriteLine();
				Console.WriteLine("이름 : " + std.Name);
				Console.WriteLine("점수 : " + std.Score);
		}


		static void TestDeleMethod()
		{
		}

	}
}
