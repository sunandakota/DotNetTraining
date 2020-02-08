using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoObjectProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = new string[6] { "jeffer", "andrew", "matthew", "james", "jacob", "trolesan" };

            var knownEmpls = from emp in employees
                             where emp.StartsWith("j")
                             select emp;

            //using query syntax
            foreach(string emp in knownEmpls)
            {
                Console.WriteLine("Empname starts with j:{0}", emp);
            }

            Console.WriteLine("*******************************************");

            //using method syntax
            var someEmpls = employees.Where(s => s.Contains("a"));
            foreach (string emp in someEmpls)
            {
                Console.WriteLine("Empname starts with a:{0}", emp);
            }

            Console.WriteLine("*******************************************");

            List<string> fruits = new List<string>() {"apple",
                                                      "grapes",
                                                      "pineapple",
                                                      "banana",
                                                      "watermelon"
                                                     };
            var fruitswithP = from fruit in fruits
                              where fruit.Contains("p")
                              select fruit;

            foreach(string fruit in fruitswithP)
            {
                Console.WriteLine("Fruit with letter P : {0}", fruit);
            }

            Console.WriteLine("*******************************************");

            var largeNameFruits = from fruit in fruits
                                  where fruit.Length > 6
                                  select fruit;
        

            foreach (string fruit in largeNameFruits)
            {
                Console.WriteLine("larger name fruit : {0}", fruit);
            }

            Console.WriteLine("*******************************************");

            //using method syntax

            var smallerNamefruits = fruits.Where(fruit => fruit.Length <= 6);

            foreach(string fruit in smallerNamefruits)
            {
                Console.WriteLine("smaller name fruit : {0}", fruit);
            }

            Console.WriteLine("*******************************************");

            int[] marks = new int[6] { 98, 85, 90, 96, 87, 96 };

            var highestmarks = from m in marks
                               where m > 90
                               select m;

            foreach(var m in highestmarks)
            {
                Console.WriteLine("highest marks : {0}", m);
            }

            Console.WriteLine("*******************************************");

            var marksInOrder = from m in marks
                               orderby m
                               select m;

            foreach(var m in marksInOrder)
            {
                Console.WriteLine("Marks in order : {0}", m);
            }
            Console.WriteLine("*****************************************");


            var marksInOrder1 = from m1 in marks
                               orderby m1 descending
                               select m1;

            foreach (var m1 in marksInOrder1)
            {
                Console.WriteLine("Marks in order : {0}", m1);
            }

            Console.WriteLine("*****************************************");

            //using method syntax

            var marksInAorder = marks.OrderBy(m => m);

            foreach (var m in marksInAorder)
            {
                Console.WriteLine("Marks in order : {0}", m);
            }

            Console.WriteLine("*****************************************");


            var marksIndorder = marks.OrderByDescending(m => m);

            foreach (var m in marksIndorder)
            {
                Console.WriteLine("Marks in order : {0}", m);
            }

            Console.WriteLine("*****************************************");

            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee() { Empid = 1, EmpName = "anders" });
            Employees.Add(new Employee() { Empid = 2, EmpName = "andrew " });
            Employees.Add(new Employee() { Empid = 3, EmpName ="jeffery" });

            var proEmpls = from emp in Employees
                           where emp.EmpName.Contains("a")
                           select new { ename = emp.EmpName };

            foreach(var emp in proEmpls)
            {
                Console.WriteLine("Employee with a : {0}", emp.ename);
            }
            Console.WriteLine("***************************************************");

            List<product> products = new List<product>();

            products.Add(new product() { productid = 1, productName = "mango drink"});
            products.Add(new product() { productid = 2, productName = "badam milk drink"});
            products.Add(new product() { productid = 3, productName = "sweets"});

            var someprod = from prod in products
                           where prod.productName.Contains("drink")
                           select new { pid = prod.productid,pname = prod.productName };

            foreach(var prod in someprod)
            {
                Console.WriteLine("productid : {0}, product Name : {1}",prod.pid, prod.pname);
            }
            Console.WriteLine("***************************************************");

            List<Teacher> Teachers = new List<Teacher>() {new Teacher() { ID = 1, firstname = "Anders", lastname = "helsberg", city = "redmond" },

                                                         new Teacher() { ID = 2, firstname = "Andrew", lastname = "trolesan", city = "lake city" },

                                                         new Teacher() { ID = 3, firstname = "jeffery", lastname = "richer", city = "Seattle" } };

            List<Student> Students = new List<Student>() {new Student() { ID = 1, firstname = "Chistrian", lastname = "Nagel", city = "redmond" },

                                                         new Student() { ID = 2, firstname = "James", lastname = "Esposito", city = "new york" },

                                                         new Student() { ID = 3, firstname = "Dino", lastname = "Mc donald", city = "Seattle" } };

            var peopleInSeattle = (from teacher in Teachers
                                   where teacher.city == "Seattle"
                                   select teacher.firstname)
                                   .Concat(from Student in Students
                                           where Student.city == "Seattle"
                                           select Student.firstname);

            foreach (var person in peopleInSeattle)
            {
                Console.WriteLine("From Seattle : {0}", person);
            }

            Console.WriteLine("*****************************************");

            Console.ReadLine();
        }

        public class Employee
        {
            public int Empid { get; set; }

            public string EmpName { get; set; }
        }

        public class product
        {
            public int productid { get; set; }

            public string productName { get; set; }
        }

        public class Teacher
        {
            public int ID { get; set; }

            public string firstname { get; set; }

            public string lastname { get; set; }

            public string city { get; set; }
        }

        public class Student
        {
            public int ID { get; set; }

            public string firstname { get; set; }

            public string lastname { get; set; }

            public string city { get; set; }
        }
    }
}
