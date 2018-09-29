using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_123_abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.Read();

            IQuittable quittable = new Employee();
            quittable.Quit();

            public static Employee operator== (Employee employee.)
        }
    }
}
