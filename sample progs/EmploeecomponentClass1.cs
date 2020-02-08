using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeecomponent
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

        public double Getincentives(double salary)
        {
            var incent = 0.05 * salary;
            return incent;
        }

        public string ShowData()
        {
            return string.Format("employeeid = {0}, empname ={1} , department = {2}",employeeid,empname,department);
        }
    }
}