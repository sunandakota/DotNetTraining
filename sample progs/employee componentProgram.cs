using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_component
{
     public class employee
     {
        public int employeeid { get; set; }

        public string empname { get; set; }

        public string department { get; set; }

        public double GetSalary(int nds, double spd)
        {
            var salary = nds * spd;
            return salary;
        }

        public double GetIncentives(double salary)
        {
            var incent = 0.05 * salary ;
            return incent;
        }

     }
}
