using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Codefirstprog1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBContext Context = new EmployeeDBContext();

            //var employee = Context.Employees;

            //var Employee1 = employee.Add(new Employee() { EmployeeID = 1, Name = "hari", Salary = 30000 });

            //var Employee2 = employee.Add(new Employee() { EmployeeID = 2, Name = "chandu", Salary = 50000 });

            //var Employee3 = employee.Add(new Employee() { EmployeeID = 3, Name = "nanda", Salary = 35000 });

            var awd = Context.Awards;

            var award1 = awd.Add(new Award() { ID = 1, AwardName = "Best Employee" });

            var award2 = awd.Add(new Award() { AwardName = "Best Employee" });
            Context.SaveChanges();
        }
    }
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext() :
            base("name=EmployeeDBContext")
        { }

        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Award> Awards { get; set; }
    }
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
    }
    public class Award
    {
        public int ID { get; set; }

        public string AwardName { get; set; }
    }
}

