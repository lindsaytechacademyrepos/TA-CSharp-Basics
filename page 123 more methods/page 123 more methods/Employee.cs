using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_123_more_methods
{
    class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public static bool operator!=(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }

        public int Id { get; set; }
    }
}
