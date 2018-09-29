using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_114_void_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoIntClass mainObject = new TwoIntClass();

            mainObject.TwoInts(x: 8, y: 9);
            Console.Read();
        }
    }
}
