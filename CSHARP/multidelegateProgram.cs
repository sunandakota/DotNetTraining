using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidelegate
{
    class Program
    {
        public delegate void mathdelegate(float a, float b);

        public delegate void printhandler();
        public event printhandler print;

        public void onprint()
        {
            Console.WriteLine("printing is done!");
        }
        public void show()
        {
            Console.WriteLine("inside show method");
            print();
        }

        static void Main(string[] args)
        {
            mathdelegate mathdeleg = new mathdelegate(addition);

            mathdeleg += subtraction;
           
            mathdeleg += multiplication;
                    
            mathdeleg += division;

            mathdeleg.Invoke(10, 20);

            Program objp = new Program();

            objp.print += new printhandler(objp.onprint); //registering onprint event handler with print event

                objp.show();

            Console.ReadKey();           
        }

        public static void addition(float a, float b)
        {
            Console.WriteLine("addition of {0} and {1} = {2}", a,b,a+b);

        }
        public static void subtraction(float a, float b)
        {
            Console.WriteLine("subtraction of {0} and {1} = {2}", a,b,a - b);

        }
        public static void multiplication(float a, float b)
        {
          
            Console.WriteLine("multiplication of {0} and {1} = {2}", a, b, a * b);

        }
        public static void division(float a, float b)
        {
            Console.WriteLine(" division of {0} and {1} = {2}", a, b, a / b);
        }
    }

}
