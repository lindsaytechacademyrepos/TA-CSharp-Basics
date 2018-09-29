using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student 1", Id = 88776 };
            //Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student 2", Id = 887 };
            //Employee employee3 = new Employee() { FirstName = "Sample", LastName = "Student 3", Id = 88776 };

            //employee1.SayName();

            //IQuittable quittable = new Employee();
            ////quittable.Quit();

            Employee<string> employeeString = new Employee<string>();
            Employee<int> employeeInt = new Employee<int>();

            employeeString.Things = new List<string>();
            employeeString.Things.Add("string1");
            employeeString.Things.Add("string2");
            employeeString.Things.Add("string3");
            employeeString.Things.Add("string4");

            employeeInt.Things = new List<int>();
            employeeInt.Things.Add(1);
            employeeInt.Things.Add(2);
            employeeInt.Things.Add(3);
            employeeInt.Things.Add(4);

            for (int i = 0; i < employeeInt.Things.Count; i++)
            {
                Console.WriteLine("Employee int value: " + employeeInt.Things[i]);
                Console.WriteLine("Employee string value: "+employeeString.Things[i]);
            }

            Console.Read();
        }
    }
}
