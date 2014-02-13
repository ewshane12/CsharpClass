using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.cs
{
    class Program
    {
        public class Person
        {
            public string hourlyName;
            public string salariedName;
            public double hourlyRate;
            public double salaryRate;
            public double age1;
            public double age2;
            public double salary1;
            public double salary2;
            public double x;
            public double y;

            public Person(string name, int age)
            {

                Console.WriteLine("Please enter the name of the hourly worker.");
                hourlyName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Thank you, now please enter the hourly workers age.");
                age1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Thank you, now please enter the hourly workers pay rate.");
                hourlyRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Thank you, now please enter the hours worked for the hourly worker.");
                x = Convert.ToDouble(Console.ReadLine());
                salary1 = ((x * hourlyRate) + 1000);//calculates salary based on hours

                Console.WriteLine("Please enter the name of the salaried worker.");
                salariedName = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Thank you, now please enter the salaried age.");
                age2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Thank you, now please enter the salaried workers pay rate.");
                salaryRate = Convert.ToDouble(Console.ReadLine());
          
                Console.WriteLine("Thank you, now please enter the hours worked for the salaried worker.");
                y = Convert.ToDouble(Console.ReadLine());
                salary2 = ((y * salaryRate));


            }

            public static void Main()
            {
                Person person1 = new Person("null", 0);// this will be overridden
                Console.WriteLine("hourlyWorker Name = {0} Age = {1} Salary = {2} Hours = {3}", person1.hourlyName, person1.age1, person1.salary1, person1.x);

                Person person2 = person1;//need to have this to create person 2

                Console.WriteLine("salariedWorker Name = {0} Age = {1} Salary = {2} Hours = {3}", person2.salariedName, person2.age2, person2.salary2, person2.y);//just overrides the previous line
       
                Console.ReadLine();
            }

        }
    }
}
