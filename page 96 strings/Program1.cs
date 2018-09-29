using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_96_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "this string " + "the other string";
            string string2 = "I definitely understarnd" + " strings at this point";
            string string3 = "concatenating three " + "strings is many strings";

            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(string3);

            Console.WriteLine(string1.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append(string1 + " this is the text I am appending");
            Console.WriteLine(sb);

            Console.Read();
            

        }
    }
}
