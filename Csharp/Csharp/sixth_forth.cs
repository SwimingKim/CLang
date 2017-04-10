using System;
using System.Threading;

namespace Csharp
{
    public class sixth_forth
    {
        static void Main()
        {
            // Thread threadA = new Thread(TestMethod);
            // Thread threadB = new Thread(delegate(){

            // });
            // Thread threadC = new Thread(()=>
            // {

            // });


            Thread threadA = new Thread(()=>{
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("A");
                }

            });
            Thread threadB = new Thread(()=>{
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }

            });
            Thread threadC = new Thread(()=>{
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();

        
        }

        // public static void TestMethod()
        // {

        // }


    }
}