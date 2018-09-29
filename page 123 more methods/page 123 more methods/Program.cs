using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_123_more_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Sample", LastName = "Student 1", Id= 88776 };
            Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Student 2", Id = 887 };
            Employee employee3 = new Employee() { FirstName = "Sample", LastName = "Student 3", Id = 88776 };

            employee1.SayName();

            IQuittable quittable = new Employee();
            //quittable.Quit();
            Console.Read();

        }
    }
}
