using System;

namespace GenericSample
{
    // int용 Stack 클래스
    public class CStackInt
    {
        int emptyStack; // 빈스텍 인덱스
        int[] items; // int 아이템 배열
        int top; // 현재 스택 커서(번호)
        int size; // 스택 크기(아이템 저장 갯수)

        // 스택 객체 생성자
        public CStackInt(int size)
        {
            this.size = size;
            items = new int[size];
            emptyStack = -1;
            top = emptyStack;
        }

        public void Push(int item)
        {
            items[++top] = item;
        }

        public int Pop()
        {
            return items[top--];
        }

        public bool IsFull()
        {
            return (top + 1) == size;
        }

        public bool IsEmpty()
        {
            return top == emptyStack;
        }

    }

	public class CStackFloat
    {
        int emptyStack; // 빈스텍 인덱스
        float[] items; // int 아이템 배열
        int top; // 현재 스택 커서(번호)
        int size; // 스택 크기(아이템 저장 갯수)

        // 스택 객체 생성자
        public CStackFloat(int size)
        {
            this.size = size;
            items = new float[size];
            emptyStack = -1;
            top = emptyStack;
        }

        public void Push(float item)
        {
            items[++top] = item;
        }

        public float Pop()
        {
            return items[top--];
        }

        public bool IsFull()
        {
            return (top + 1) == size;
        }

        public bool IsEmpty()
        {
            return top == emptyStack;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 제너릭 사용하지 않았을 때 스택을 사용하는 코드
            int size = 5;
            CStackFloat istack = new CStackFloat(size);

            for (int i = 0; i < 7; i++)
            {
                if (!istack.IsFull())
                {
                    istack.Push(((float)i) + 0.2f);
                }
				else
				{
					System.Console.WriteLine("스택이 꽉 찼습니다. [저장 실패 : "+ i + "]");
				}
            }

			while (!istack.IsEmpty())
			{
				System.Console.WriteLine(istack.Pop());
			}

        }

    }

}
