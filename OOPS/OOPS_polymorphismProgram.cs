using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            var salary = emp.Getsalary(30, 800);
            Console.WriteLine("salary without incentives: Rs {0}", salary);

            salary = emp.Getsalary(30, 800, 500);
            Console.WriteLine("salary with incentives: Rs {0}", salary);

            manager objm = new manager();
            var ts = objm.Getperks(30000, 5000);
            Console.WriteLine("salary of manager :Rs {0}", ts);
            Console.ReadKey();
        }
    }
      public class employee
      {
          public double Getsalary(int nds, float spd)
          {
                double salary = nds * spd;
                return salary;
          }

          public double Getsalary(int nds, float spd, float incent)
          {
                double salary = (nds * spd) + incent;
                return salary;
          }

          //this method will be overridden in some other derived class
          public virtual double Getperks(float salary, float perks)
          {
            //return string.Format("congratulations mr/mrs {0} for getting RS {1} as perks", name, perks);
            double ts = salary + perks;
            return ts;
          }
       
      }
    
    public class manager : employee
    {
        public override double Getperks(float salary, float perks)
        {
            return base.Getperks(salary, perks) * 1.10;
            //double ts = 1.10 * (salary + perks);
            //return ts;
        }
    }
    
}
