﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleEFDBfirstprog
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqToEntity();
            ModifyEmployee();
            DeleteEmployee();

            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            //var employee = new Employee()
            //{
            //    EmpID = 1,
            //    Name = "Andrew Trolesan",
            //    Salary = 35000,
            //    SSN = 23456,
            //    DepID = 3
            //};
            //context.Employees.Add(employee);
            //context.SaveChanges();

            //var employee2 = new Employee()
            //{
            //    EmpID = 2,
            //    Name = "Jeffery Richer",
            //    Salary = 35000,
            //    SSN = 34567,
            //    DepID = 3
            //};
            //context.Employees.Add(employee2);

            //var employee3 = new Employee()
            //{
            //    EmpID = 3,
            //    Name = "Andrew Trolesan",
            //    Salary = 39000,
            //    SSN = 34567,
            //    DepID = 3
            //};
            //context.Employees.Add(employee3);
            context.SaveChanges();
        }

        public static void LinqToEntity()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var empList = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in empList)
            {
                Console.WriteLine("EmpID:{0} ,Name:{1}, Salary:{2}, SSN:{3}", emp.EmpID, emp.Name, emp.Salary, emp.SSN);
            }
        }
        public static void ModifyEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var empList = from emp in employees
                          orderby emp.Salary
                          select emp;
            foreach (var emp in empList)
            {
                if (emp.EmpID == 1)
                    emp.Name = "Matthew McDonald";
            }
            context.SaveChanges();
        }

        public static void DeleteEmployee()
        {
            EmployeeEFDBEntities context = new EmployeeEFDBEntities();
            var employees = context.Employees;

            var employee = new Employee() { EmpID = 4 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();
        }
    }
}
