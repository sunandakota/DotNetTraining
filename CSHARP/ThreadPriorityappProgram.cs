using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Theardpriorityapp
{
    class Program
    {
        public static long count1, count2;
        static void Main(string[] args)
        {
            Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);

            Console.WriteLine("The Main thread is started");

            T1.Start();
            T2.Start();

            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;

            Thread.Sleep(1000);

            T1.Abort();
            T2.Abort();

            T1.Join();
            T2.Join();
            Console.WriteLine("Count1:{0}", count1);
            Console.WriteLine("Count2:{0}", count2);

            Console.WriteLine("The Main thread is exited ");

        }
        public static void IncrementCount1()
        {
            while(true)
            {
                count1 += 1;
            }
            Console.WriteLine("Count1:{0}", count1);
        }

        public static void IncrementCount2()
        {
            while (true)
            {
                count2 += 1;
            }
            Console.WriteLine("Count2:{0}", count2);
        }
    }
}
