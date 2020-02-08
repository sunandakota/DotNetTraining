using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace MultiThreadAppPerform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread has started");
            Stopwatch s1 = new Stopwatch();

            s1.Start();
            IncrementCount1();
            IncrementCount2();
             s1.Stop();

            Stopwatch s2 = new Stopwatch();

            Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);


            s2.Start();
            T1.Start();
            T2.Start();
            s2.Stop();

            T1.Join();
            T2.Join();


            Console.WriteLine("Total Time Elapsed for a single Threaded Application :{0} ", s1.ElapsedMilliseconds);

            Console.WriteLine("Total Time Elapsed for a Multi Threaded Application :{0} ", s2.ElapsedMilliseconds);

            Console.WriteLine("Main thread has exited");
        }
        public static void IncrementCount1()
        {
            long count1 = 0;
            for (int i = 0; i < 1000000; i++)
                count1++;

            Console.WriteLine("count1:{0}", count1);
        }
        public static void IncrementCount2()
        {
            long count2 = 0;
            for (int i = 0; i < 1000000; i++)
                count2++;

            Console.WriteLine("count2:{0}", count2);

        }

    }
}
