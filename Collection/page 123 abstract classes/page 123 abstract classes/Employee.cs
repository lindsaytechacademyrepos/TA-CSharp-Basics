using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_123_abstract_classes
{
    class Employee: Person, IQuittable
    {
        public void SayName()
        {
            Console.Write(FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.Read();
        }
    }
}
