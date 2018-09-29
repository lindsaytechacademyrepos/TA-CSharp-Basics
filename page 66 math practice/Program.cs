using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_66_math_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
            Console.WriteLine("Please input a number");
            string userInput1 = Console.ReadLine();
            int int1 = Convert.ToInt32(userInput1);
            Console.WriteLine("50 times " + userInput1 + " is " + int1 * 50);


            //2. Takes an input from the user, adds 25 to it, and prints the result to the console.
            Console.WriteLine("Please input another number");
            string userInput2 = Console.ReadLine();
            int int2 = Convert.ToInt32(userInput2);
            Console.WriteLine(userInput2 + " + 25 = " + (int2 + 25));


            //3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
            Console.WriteLine("Please input another number");
            string userInput3 = Console.ReadLine();
            int int3 = Convert.ToInt32(userInput3);
            Console.WriteLine(userInput3 + " divided by 12.5 = " + (int3 / 12.5));


            //4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
            Console.WriteLine("Please input another number");
            string userInput4 = Console.ReadLine();
            int int4 = Convert.ToInt32(userInput4);
            Console.WriteLine("Is the number you selected greater than 50? " + (int4 > 50));


            //5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).
            Console.WriteLine("Please input a number greater than 7");
            string userInput5 = Console.ReadLine();
            int int5 = Convert.ToInt32(userInput5);
            Console.WriteLine("The remainder of " + userInput5 + " divded by 7 is " + int5 % 7);

            Console.WriteLine("Hit Enter to exit the program.");
            Console.Read();
        }
    }
}
