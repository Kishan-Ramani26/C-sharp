using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Practical_Assignment_1
{
    internal class PAQ6
    {
        static void Main(string[] args)
        {
            double mm = 0, m = 0;

            Console.Write("Enter mm : ");
            mm = Double.Parse(Console.ReadLine());

            Console.WriteLine("mm to cm : " + mm / 10 + "cm");

            Console.Write("Enter m : ");

            m = Double.Parse(Console.ReadLine());

            Console.WriteLine("m to km : " + m / 1000 + "km");

        }
    }
}
