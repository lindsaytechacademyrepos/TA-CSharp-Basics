using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_114_void_methods
{
    class TwoIntClass
    {
        public void TwoInts(int x, int y)
        {
            int mathOperation = x ^ y;
            Console.WriteLine("The second integer is " + y);
        }
    }
}
