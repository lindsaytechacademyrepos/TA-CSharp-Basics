using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_110_methods_and_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Class1 class1 = new Class1();

            
            Console.WriteLine("Your first number squared is: " + class1.NumSquared(num1));
            Console.WriteLine("Your two numbers added together is: " + class1.AddTwoNumbers(num1, num2));
            Console.WriteLine("The first number subtracted from the second number is: " + class1.SubtractNumbers(num1, num2));
            Console.Read();

            
        }
    }
}
