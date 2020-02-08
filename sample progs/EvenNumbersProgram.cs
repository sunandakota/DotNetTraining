using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        
            static int n;
            static void Main(string[] args)
            {
                Console.WriteLine("Enter length of array");
                n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                Console.WriteLine("Enter the array values");
                for (int i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                var en = from e in a
                         where e % 2 == 0
                         select e;
                Console.WriteLine("even numbers are:");
                foreach (var i in en)
                {
                    Console.WriteLine("{0}", i);
                }

            }
        }
    }

