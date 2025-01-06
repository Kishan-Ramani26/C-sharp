using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Practical_Assignment_1
{
    internal class PAQ8
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total, avg, percentage;

            Console.Write("Enter subject 1 marks : ");
            sub1 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter subject 2 marks : ");
            sub2 = Int32.Parse(Console.ReadLine());

            Console.Write("Enter subject 3 marks : ");
            sub3 = Int32.Parse(Console.ReadLine());

            total = sub1 + sub2 + sub3;
            avg = total / 3;
            percentage = (100*total)/300;

            Console.WriteLine("Total : " + total);
            Console.WriteLine("Average : " + avg);
            Console.WriteLine("Percentage : " + percentage + "%");
        }
    }
}
