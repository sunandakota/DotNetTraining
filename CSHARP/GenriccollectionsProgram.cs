using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Genriccollectionsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100);
            items.Add("Hello world");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);
            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            List<int> myInts = new List<int>();
            myInts.Add(10);
            myInts.Add(80);
            //myInts.Add(10);
            myInts.Add(90);
            foreach (var n in myInts)
                Console.WriteLine(n.ToString());

            List<string> Employees = new List<string>() { "hari chandana", "chandu", "manisha", "praveena", "navya" });



            foreach (var emp in Employees)
                Console.WriteLine(emp);

            Dictionary<int, string> fruits = new Dictionary<int, string>();

            fruits.Add(1, "mango");

            fruits.Add(2, "watermelon");
            fruits.Add(3, "cickko");
            fruits.Add(4, "apple");
            fruits.Add(5, "guava");
            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key->{0},value->{1}", kv.Key, kv.Value);
            }









            fruits.Remove(4);
            fruits.Add(4, "grapes");
            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("key->{0},value->{1}", kv.Key, kv.Value);
            }
            SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();  //sorts in ascending order and then retrives them
            gadgets.Add(3, "thinkpad3");
            gadgets.Add(5, "thinkpad5");

            gadgets.Add(1, "thinkpad1");

            gadgets.Add(4, "thinkpad4");
            gadgets.Add(2, "thinkpad2");
            foreach (KeyValuePair<int, string> kv in gadgets)
            {
                Console.WriteLine("key->{0},value->{1}", kv.Key, kv.Value);
            }
            List<employe> employe = new List<employe>();

            employe.Add(new employe() { Id =10; Name = "nani1",Dept = "eee1"});
        employe.Add(new employe)(){Id = 20;Name="hani";Dept="eee2"});
        
        employe.Add(new employee() {Id = 12; Name = "nani1",Dept = "eee1"});
             
           foreach(var emp in employe)
            {
              Console.WriteLine("Id={0},Name = {1},Dept={2}",emp.Id,emp.Name,emp.Dept);
            }
           Console.ReadKey();
         } 






    public class employe
    {
      public int Id

       { get; set; }


       public string Name
       { get; set; }


       public string Dept
       { get; set; }
    }
}
    
   




           

       

    
       

    

