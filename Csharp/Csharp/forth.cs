using System;
using System.Collections.Generic;

namespace Csharp
{
	public class forth
	{
		class Product {

			public string name;

			public Product(string n)
			{
				this.name = n;
				Console.WriteLine (this.name + " 생성");
			}

			~Product() // 소멸자
			{
				Console.WriteLine (this.name + "의 소멸자 호출");
			}
		}

		class MyMath
		{
			public static double PI = 3.14;
			public const double PI2 = 3.14; // 상수화하고 싶으면 static을 안써도 클래스에서 바로 접근 가능
		}

		class Box
		{
			private int width;
			public int Width
			{
				get {
					return width;
				}
				set
				{
					if (value > 0) {
						this.width = value;
					} else
						Console.WriteLine ("너비를 자연수를 입력하세요");
				}
			}
			private int height;
			public int Height
			{
				get {
					return height;
				}
				set
				{
					if (value > 0) {
						this.height = value;
					} else
						Console.WriteLine ("높이를 자연수를 입력하세요");
				}
			}

			private string color;
			public string Color {
				get;
				set;
			}

			private int num;
			public int Num {
				get;
				set;
			}
			private int id;
			public int Id
			{
				get
				{
					return id;
				}
				set
				{
					if (value > 0) {
						this.id = value;
					} else {
						Console.WriteLine ("ID는 자연수를 입력하세요");
					}
				}
			}

			/*
			public Box(int w, int h)
			{
				if (w > 0 && h > 0)
				{
					this.width = w;
					this.height = h;
				}
				else Console.WriteLine ("자연수를 입력하세요.");
			}
			*/

			public Box(int w, int h)
			{
				Width = w;
				Height = h;
			}

			public int Area()
			{
				return this.width * this.height;
			}

			// Getter Method
			public int GetWidth() { return width; }
			public int GetHeight() { return height; }
			// Setter Method
			public void SetWidth(int w)
			{
				if (w > 0) {
					this.width = w;
				} else
					Console.WriteLine ("너비는 자연수를 입력하세요");
			}
			public void SetHeight(int h)
			{
				if (h > 0) {
					this.height = h;
				} else
					Console.WriteLine ("높이는 자연수를 입력하세요");
			}
		}

		static void Change(Test input)
		{	
			input.value = input.value*2;
		}

		class Test
		{
			public int value = 10;
		}

		class Animal
		{
			public int Age { get; set; }
			public Animal() { this.Age = 0; }
			public void Eat() { Console.WriteLine ("냠냠"); }
			public void Sleep() { Console.WriteLine ("쿨쿨"); }
			public void PublicF() {}
			private void PrivateF() {}
			protected void ProtectedF() {}
			public void Test1() {
				PublicF ();
				PrivateF ();
				ProtectedF ();
			}
		}

		class Dog : Animal
		{
			public string Color {
				get;
				set;
			}
			public void Bark()
			{
				Console.WriteLine ("멍멍");
			}
			public void Test()
			{
				base.Eat ();
				base.PublicF ();
//				base.PrivateF ();
				base.ProtectedF ();
			}
		}
		class Cat : Animal 
		{
			public void Meow()
			{
				Console.WriteLine ("야옹");
			}
		}

		class mParent
		{
			public mParent()
			{
				Console.WriteLine ("부모 생성자");
			}
			public mParent(int param)
			{
				Console.WriteLine ("int 부모 생성자");
			}
			public mParent(string param)
			{
				Console.WriteLine ("string 부모 생성자");
			}
		}

		class mChild : mParent
		{
			public mChild () : base(10)
			{
				Console.WriteLine ("자식 생성자");
			}
			public mChild (int i) : base(i)
			{
				Console.WriteLine ("int 자식 생성자");
			}
			public mChild (string test) : base(test)
			{
				Console.WriteLine ("string 자식 생성자");
			}
		}

		class Parent
		{
			public static int count = 0;
			public void CountParent()
			{
				Parent.count++;
			}
		}

		class Child : Parent
		{
			public void CountChild()
			{
				Child.count++;
			}
		}

		public static int num = 10;

		class sParent
		{
			public int variable = 273;
			public virtual void Method()
			{
				Console.WriteLine ("부모의 메소드");
			}
		}

		class sChild : sParent
		{
			public new string variable = "hiding"; // 메소드를 hiding함을 표시
			public override void Method() // 오버라이딩
			{
				Console.WriteLine ("자식의 메소드");
			}
		}

//		sealed class oAnimal : 상속하지 않는다
		abstract class oAnimal 
		{
			// 메소드를 추상화하려면 클래스도 추상화시켜야 함
//			public override abstract void Eat ();
//			public new abstract void Eat ();
			public abstract void Eat ();
			/*
			public virtual void Eat()
			{
				Console.WriteLine ("냠냠");
			}
			*/
		}

		class oDog : oAnimal
		{
			sealed public override void Eat()
			{
				Console.WriteLine ("강아지 사료");
			}
		}

		class oCat : oAnimal
		{
			public override void Eat ()
			{
				Console.WriteLine ("고양이 사료");
			}
		}

		class BullDog : oDog
		{
			/*
			public override void Eat()
			{
				Console.WriteLine ("뼈다귀 사료");
			}
			*/
		}

		public static void Main(string[] args)
		{
			Product pro1 = new Product ("Tomato");
			Product pro2 = new Product ("Banana");
			Product pro3 = new Product ("Potato");

//			Math.PI = 3.14; // 상수(const)이므로 변경 불가 
			MyMath.PI = 3.14;
			int r = 10;
			Console.WriteLine ("둘레 : " + 2*MyMath.PI*r);
			Console.WriteLine ("넓이 : " + MyMath.PI*r*r);

			Console.Clear ();
			Box box1 = new Box (-10, -20);
			box1.Width = 100;
			Console.WriteLine ("너비 = " + box1.Width);

			int a = 10;
			int b = a;
			b *= 2;
			Console.WriteLine (a);

			Test tt = new Test ();
			tt.value = 10;
			Change (tt);
			Console.WriteLine (tt.value);

			Test t1 = new Test ();
			Test t2 = t1;
			t2.value = t1.value;
			t1.value = 10;
			t2.value = 20;
			Console.WriteLine (t1.value);

			List<Dog> Dogs = new List<Dog> (){ new Dog (), new Dog (), new Dog () };
			List<Cat> Cats = new List<Cat> (){ new Cat (), new Cat (), new Cat () };

			/*
			foreach (var item in Dogs) {
				item.Eat ();
				item.Sleep ();
				item.Bark ();
			}
			foreach (var item in Cats) {
				item.Eat ();
				item.Sleep ();
				item.Meow ();
			}
			*/

			Dog dog1 = new Dog();
			dog1.PublicF ();
//			dog1.ProtectedF ();
//			dog1.ProtectedF ();

			Animal mdog = new Dog();
			Animal mcat = new Cat();

//			mdog.Bark (); // Animal 클래스의 인스턴스이므로 Dog 클래스의 메소드 사용 불가 

			List<Animal> Anims = new List<Animal>{
				new Dog(), new Cat(), new Cat (), new Dog (), new Dog (), new Cat ()
			};

			foreach (var item in Anims) {
				item.Eat ();
				item.Sleep ();
				if (item is Dog) {
					((Dog)item).Bark ();
				}
				var cat = item as Cat;
				if (cat!=null) {
					cat.Meow ();
				}
			}

			Animal anim = new Dog ();
			anim.Eat ();
//			anim.Bark ();
			((Dog)anim).Bark ();

			List<Object> list = new List<Object>();
			list.Add (new Dog());
			list.Add (new Cat());
			list.Add (new Animal());
			list.Add (52);
			list.Add (3.14);
			list.Add ("abc");
			((Dog)list [0]).Bark ();

			mChild ch = new mChild ();
			mChild chInt = new mChild (10);
			mChild chStr = new mChild ("ABC");

			Parent prn = new Parent ();
			Child chl = new Child ();

			prn.CountParent ();
			chl.CountChild ();

			Console.WriteLine (Parent.count + " : " + Child.count);

			int num = 20; // shadowing (하나의 클래스에서 가려지는 것)
			Console.WriteLine ("num = "+num);

			sChild schl = new sChild();
			Console.WriteLine (schl.variable); // hiding (상속관계에서 자식클래스에 의해 부모클래스가 가려지는 것)
			Console.WriteLine (((sParent)schl).variable);
			Console.WriteLine ((schl as sParent).variable);
			schl.Method ();
			((sParent)schl).Method ();
			(schl as sParent).Method ();

			List<oAnimal> olist = new List<oAnimal> () {
				new oDog(), new oDog (), new oCat (), new oCat (), new oDog (), new oCat ()	
			};
			foreach (var item in olist) {
				item.Eat ();
			}

//			new BullDog ().Eat ();
//			oAnimal aa = new oAnimal (); // 추상 클래스가 되서 선언을 하지 못함
		}
	}
}

