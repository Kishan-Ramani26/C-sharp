using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class employe
    {
        int age;
        double salary;
        string name;

        public void getData(int age,double salary,string name)
        {
            this.age = age; 
            this.salary = salary;
            this.name = name;
        }

        public void showData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Salary : " + salary);
        }

    }


    internal class PSQ1
    {
        public static void Main(string[] args)
        {
            int age;
            double salary;
            string name;

            Console.Write("Enter Name : ");
            name = Console.ReadLine();

            Console.Write("Enter age : ");
            age = Int32.Parse(Console.ReadLine());

            Console.Write("Enter salary : ");
            salary = double.Parse(Console.ReadLine());

            employe e1 = new employe();

            e1.getData(age, salary, name);
            e1.showData();
        }
    }
}
