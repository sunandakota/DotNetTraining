using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreadingApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("main thread is strated");

            Thread t = Thread.CurrentThread;
            t.Name = "main method";

            Console.WriteLine("{0} is running now with ID:{1}", t.Name, t.ManagedThreadId);


            //method1();
            //method2();
            //method3();

            Thread T1 = new Thread(new ThreadStart(method1));
            Thread T2 = new Thread(method2);  //Method2 is implicitly handled by ThreadStart delegate
            Thread T3 = new Thread(method3);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();T2.Join();T3.Join();

            Thread Tp = new Thread(new ParameterizedThreadStart(test));
           // Tp.Start(100);

            Thread Tarea = new Thread(new ThreadStart(findArea));
            Tarea.Start();

            Console.WriteLine("main thread is exited");
            Console.ReadKey();
        }

        public static void method1()
        {
            Console.WriteLine("thread1 is started");
            for (int i = 1; i <= 50; i++)
                Console.WriteLine("method1 :{0}", i);
            Console.WriteLine("thread1 is exited");
        }

        public static void method2()
        {
            Console.WriteLine("thread2 is started");
            for (int i = 1; i <= 50; i++)
            {
                if (i == 25)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("method2 :{0}", i);               
            }
            Console.WriteLine("thread2 is exited");
        }
        public static void method3()
        {
            Console.WriteLine("thread3 is started");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("method3 :{0}", i);
                
                //if (i == 25)
                //{
                //    T3.Suspend();
                //}
            }
            Console.WriteLine("thread3 is exited");
        }

        public static void test(object max)
        {
            int j = Convert.ToInt32(max);
            for (int i = 1; i <= j; i++)
            {
                Console.WriteLine("Test : {0}", i);
            }
        }

        public static void findArea()
        {
            double len, brd;

            Console.WriteLine("enter length");
           len = double.Parse(Console.ReadLine());

            Console.WriteLine("enter breadth");
             brd = double.Parse(Console.ReadLine());

            Console.WriteLine("area of rectangle : {0}", (len*brd).ToString());

        }
    }
}
