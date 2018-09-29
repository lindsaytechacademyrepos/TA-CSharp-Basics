using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_67_income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison Program");

            //It must then print “Person 1” to the screen and get the following details:
            //Hourly Rate
            //Hours worked per week

            Console.WriteLine("Person 1: ");
            Console.WriteLine("Please enter hourly rate");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Please enter total number of hours worked");
            string hoursWorked1 = Console.ReadLine();
            int intRate1 = Convert.ToInt32(hourlyRate1);
            int intWorked1 = Convert.ToInt32(hoursWorked1);


            //It must then print “Person 2” to the screen and then get the following details:
            //Hourly rate
            //Hours worked per week
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Please enter hourly rate");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Please enter total number of hours worked");
            string hoursWorked2 = Console.ReadLine();
            int intRate2 = Convert.ToInt32(hourlyRate2);
            int intWorked2 = Convert.ToInt32(hoursWorked2);

            //It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            Console.WriteLine("Annual salary of Person 1:");
            int annualSalary1 = intRate1 * intWorked1;
            Console.WriteLine(annualSalary1);

            //It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
            Console.WriteLine("Annual salary of Person 2:");
            int annualSalary2 = intRate2 * intWorked2;
            Console.WriteLine(annualSalary2);

            //It must then print to the screen “Does Person 2 make more money than Person 2?” and write the true or false value of this statement below it.
            Console.WriteLine("Does Person 2 make more money than Person 1?");
            Console.WriteLine(annualSalary2 > annualSalary1);

            Console.Read();
        }
    }
}
