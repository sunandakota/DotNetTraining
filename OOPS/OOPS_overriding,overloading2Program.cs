using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            add a = new add();
            var result = a.Getresult(30, 800);
            Console.WriteLine("addition of a and b : {0}", result);

            result = a.Getresult(30, 800, 500);
            Console.WriteLine("operation on three numbers : {0}", result);
            mult m = new mult();
            var ts = m.Getanswer(30, 30);
            Console.WriteLine("result of mult : {0}", ts);

            Console.ReadKey();
        }
    }
    public class add
    {
        public double Getresult(float a, float b)
        {
            double result = a + b;
            return result;
        }

        public double Getresult(int a, float b, float c)
        {
            double result = (a * b) + c;
            return result;
        } 
        public virtual double Getanswer(float result, float answer)
        {
            double ts = result + answer;
            return ts;
        }
    }
    public class mult : add
    {
        public override double Getanswer(float result, float answer)
        {
            return base.Getanswer(result, answer) * 10;
        }
    }
}
        