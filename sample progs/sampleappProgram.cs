﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 9; b = 5;
            Multiply(a, b);
            Addition(a, b);
            for (int i = 1; i<=5;i++)
            {
               var result = 40 + i;
                Console.WriteLine("result = {0}", result);
            }
        }

        public static double Multiply(int a,int b)
        {
            var prod = a * b;
            return prod;
        }

        public static double Addition(int a , int b)
        {
            var add = a + b;
            return add;
        }
    }
}
