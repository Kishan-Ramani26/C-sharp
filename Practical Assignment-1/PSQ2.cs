using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Practical_Assignment_1
{
    internal class PSQ2
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter number : ");
            a = Int32.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is odd");
            }
            Console.Read();
        }

    }
}
