using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Exercises
{
    abstract class Person
    {
        public abstract void SayName();


        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
