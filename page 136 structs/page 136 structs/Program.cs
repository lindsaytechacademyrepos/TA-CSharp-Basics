using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_136_structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 4.5m };
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
