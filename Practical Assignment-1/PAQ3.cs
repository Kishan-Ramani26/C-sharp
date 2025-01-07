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

        public void getData(int age, double salary, string name)
        {
            this.age = age;
            this.salary = salary;
            this.name = name;
        }

        public int getAge() { return age; }

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
            employe e2 = new employe();
            employe e3 = new employe();


            e1.getData(age, salary, name);
            e2.getData(age, salary, name);
            e3.getData(age, salary, name);

            Console.WriteLine("Oldest Eploye : ");

            if (e1.getAge() > e2.getAge())
            {
                e2.showData();
            }
            else if (e2.getAge() > e3.getAge()) 
            { e3.showData(); }
            else
            {
                e1.showData();
            }
        }
    }
}
