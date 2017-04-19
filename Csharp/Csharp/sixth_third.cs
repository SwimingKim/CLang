using System;

namespace Csharp
{
    public class sixth_third
    {
        public delegate void SendString(string message);
        public delegate void SendFunc(int s);

        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, sayGoodNight, multiDelegate;
            SendFunc sayNumber;

            sayHello = Hello;
            sayGoodbye = Goodbye;
            sayGoodNight = Goodbye;
            sayNumber = NumberFunc;

            sayHello("홍길동");
            sayGoodbye("홍길동");

            Console.WriteLine();

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("홍길동");

            Console.WriteLine();

            multiDelegate -= sayGoodbye;
            multiDelegate("사임당");

            multiDelegate -= sayGoodNight;
            multiDelegate("장동건");

            Console.WriteLine();

            // multiDelegate -= sayNumber; // 동일한 델리게이트 형식에서만 연산 가능
            // multiDelegate("장동건");

        }

        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요 "+message+"씨");
        }

        public static void Goodbye(string message)
        {
            Console.WriteLine("안녕히 가세요 "+message+"씨");
        }

        public static void NumberFunc(int n)
        {
            Console.WriteLine("Number = "+n);
        }
    }
}