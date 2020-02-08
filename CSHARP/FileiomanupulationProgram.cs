using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fileiomanipulationdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("c:\\SampleDirectory");
            //dir.Create();

            //FileInfo file = new FileInfo(@"c:\SampleDirectory\sample.txt");
            //file.Create();
            //Console.WriteLine("THE DIRECTORY AND THE TEXT FILE HAVE BEEN CREATED SUCCESSFULLY");
            FileStream fs = new FileStream(@"c:\SampleDirectory\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);

           StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This text has been written to the file using file iput/output manipulation");
            FileStream a = new FileStream(@"c:\SampleDirectory\Sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter b = new StreamWriter(a);
            sw.WriteLine("This text has been written to the file using file append");

            sw.Close();
            fs.Close();
            Console.WriteLine("Some content is written to the file");

            fs = new FileStream(@"c:\SampleDirectory\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            var content = sr.ReadToEnd();
            Console.WriteLine("The file content: {0}", content);
            string lineByLine;
            while ((lineByLine = sr.ReadLine()) != null)
            {
                Console.WriteLine("\n the file content:{0}", lineByLine);
            }
        }
    }
}