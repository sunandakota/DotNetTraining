using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threadlockingapp
{
    class ThreadLock
    {
        static void Main(string[] args)
        {
            ThreadLock objTL = new ThreadLock();

            Thread T1 = new Thread(objTL.Display);
            Thread T2 = new Thread(objTL.Display);
            Thread T3 = new Thread(objTL.Display);

            T1.Start();
            T2.Start();
            T3.Start();
            Console.ReadKey();
        }

        public void Display()
        {
            lock (this) //this locks the resource for any thread to complete its task of execution
            {
                Console.Write("[CSharp is an");
                Thread.Sleep(3000);
                Console.WriteLine(" object oriented language]");
            }
        }
    }
}
