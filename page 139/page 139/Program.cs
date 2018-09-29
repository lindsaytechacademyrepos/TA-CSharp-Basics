using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_139
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee { FirstName = "Joe", LastName = "Shmo", Id = 987987 };
            Employee employee2 = new Employee { FirstName = "Alice", LastName = "Stevens", Id = 234234 };
            Employee employee3 = new Employee { FirstName = "Steve", LastName = "Stuart", Id = 345345 };
            Employee employee4 = new Employee { FirstName = "Kendra", LastName = "Barnes", Id = 56456456 };
            Employee employee5 = new Employee { FirstName = "Lindsay", LastName = "Cutter", Id = 2213234 };
            Employee employee6 = new Employee { FirstName = "Joe", LastName = "Evans", Id = 7567 };
            Employee employee7 = new Employee { FirstName = "Aaron", LastName = "Henry", Id = 2342342 };
            Employee employee8 = new Employee { FirstName = "Joe", LastName = "Ford", Id = 567567 };
            Employee employee9 = new Employee { FirstName = "Stephanie", LastName = "Lester", Id = 234234234 };
            Employee employee10 = new Employee { FirstName = "Evan", LastName = "Walker", Id = 234234 };

            List<Employee> newList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            List<Employee> lambdaList = employees.Where(x => x.FirstName =="Joe").ToList();

            List<Employee> listById = employees.Where(x => x.Id > 5).ToList();
        }
    }
}
