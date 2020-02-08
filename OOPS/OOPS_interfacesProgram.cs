using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 85, 95, 95, 84, 74, 96 };
            result objr = new result();
            var avg = objr.GetAverageMarks(marks);
            objr.DisplayAverage(avg);
            objr.ShowGrade(avg);

            Console.ReadKey();
        }
    }
    public interface iexam
    {
        double GetAverageMarks(int[] marks);
        void DisplayAverage(Double avg);
    }
    public interface istudent
    {
        void ShowGrade(double avg);
    }
    public class result : iexam, istudent
    {
        public void DisplayAverage (double avg)
        {
            Console.WriteLine("the average marks = {0}", avg);
        }
        public double GetAverageMarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];
            avg = total / marks.Length;
            return avg;
        }
        public void ShowGrade(double avg)
        {
            if (avg >= 70.00)
                Console.WriteLine("passed in distinction");
            else
                Console.WriteLine("not a distinction");
        }
    }
}
