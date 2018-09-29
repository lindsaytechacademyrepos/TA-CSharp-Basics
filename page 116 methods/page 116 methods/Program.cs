using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_116_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVoidMethod testMethod = new TestVoidMethod();
            Console.WriteLine("Please enter a number");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            testMethod.TestMethod(userInput1, out int result);
            Console.WriteLine("First method result: The number you entered divided by two is " + result);

            Console.Write("Overloaded method result: " + TestStaticClass.TestMethod(userInput1));
            Console.Read();

        }
    }
}
