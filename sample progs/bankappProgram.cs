using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;


namespace Bankclientapp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsBank objsb = new SavingsBank();

            Console.WriteLine("enter the principle amount");
            var p = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the time in years");
            var t = double.Parse(Console.ReadLine());

            Console.WriteLine("enter rate of interest");
            var r = double.Parse(Console.ReadLine());

            var SI = objsb.Getsimpleintrest(p, t, r);

            Console.WriteLine("simple interest : {0}", SI);

            var balance = objsb.Getbalance();

            Console.WriteLine("balance: Rs {0}", balance);

            Console.ReadLine();


        }
    }
}
