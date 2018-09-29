using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public abstract class Person
    {
        public abstract void SayName();
        //{
            // Console.WriteLine("Name: " + FirstName + " " + LastName);
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
