using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_112_methods_and_classes_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            page112Class testObject = new page112Class();

            Console.WriteLine("Please input a number");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a decimal value");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please input a string");
            string userInput3 = Console.ReadLine();

            Console.WriteLine("The result of the first method is " + testObject.method1(userInput1));
            Console.WriteLine("The result of the second method is " + testObject.method2(userInput2));
            Console.WriteLine("The result of the third method is " + testObject.method3(userInput3));

            Console.Read();

        }
    }
}
