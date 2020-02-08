using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            string strRev = null;

            char[] chars = str.ToCharArray();

            for (int i = str.Length-1;i>=0;i--)
            {
                strRev += chars[i];
            }
            Console.WriteLine("reverse of {0} = {1}", str, strRev);

        }
        

    }
}
