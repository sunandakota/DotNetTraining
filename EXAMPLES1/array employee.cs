using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employee = new string[2] { "sunny", "denny" };
            for (int i = 0; i < employee.Length; i++)
                Console.WriteLine("employee = {0}", employee[i]);
               Console.ReadKey();
        }
    }
}
