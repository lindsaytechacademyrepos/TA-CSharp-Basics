using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_113_methods_and_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            exercise113Class testObject = new exercise113Class();

            Console.WriteLine("Please input a number");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Optional) Please input another number");
            

            try
            {
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your first number + your second number is "+ testObject.twoIntMethod(userInput1, userInput2));
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Your first number divded by the default number of 2 is "+testObject.twoIntMethod(userInput1));
            }

            finally
            {
                Console.Read();
            }
            
        }
    }
}
