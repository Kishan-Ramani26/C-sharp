using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Practical_Assignment_1
{
    internal class PAQ5
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, input;

            Console.Write("Enter a number : ");
            input = Int32.Parse(Console.ReadLine());

            Console.Write(num1 + " " + num2 + " ");

            for (int i = 2; i < input; i++)
            {
                num3 = num1 + num2;

                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
