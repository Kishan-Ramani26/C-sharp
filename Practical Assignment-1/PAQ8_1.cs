using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Practical_Assignment_1
{
    internal class PAQ8_1
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter number : ");
            a = Int32.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(a + " * " + i + " = " + (a * i));
            }
        }
    }
}
