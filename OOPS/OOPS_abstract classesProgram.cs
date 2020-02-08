using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes_demo_program
{
    class Program
    {
        static void Main(string[] args)
        {
            sbaccount objsb = new sbaccount();

            ccaccount objcc = new ccaccount();

            double sisb = objsb.GetSimpleInterest(95000.00, 5, 8);
            double tamt = objsb.GetTotalAmount(50000.00, sisb);

            Console.WriteLine("simple interest(svaings bank): Rs {0}", sisb);
            Console.WriteLine("total amount: Rs {0}", tamt);

            var sicc = objcc.GetSimpleInterest(95000.00, 5, 8);
            tamt = objcc.GetTotalAmount(50000.00, sicc);

            Console.WriteLine("simple interest(svaings bank): Rs {0}", sicc);
            Console.WriteLine("total amount: Rs {0}", tamt);

            objsb.show();
        }
    }
    public abstract class banking
    {
        public abstract double GetSimpleInterest(double pr, int td, short rt);
        public abstract double GetTotalAmount(double bal, double si);

        public void show()
        {
            Console.WriteLine("this is a concrete method defined within an abstract class");
        }
    }
    public class sbaccount : banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }

    public class ccaccount : banking
    {
        public override double GetSimpleInterest(double pr, int td, short rt)
        {
            double si = 0.25 *((pr * td * rt) / 100);
            return si;
        }
        public override double GetTotalAmount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }

}