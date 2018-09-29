using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_164_more_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Please enter your age");
                    validAnswer = (int.TryParse(Console.ReadLine(), out age));
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("You may only enter digists");
                
            }
            
            


            Console.Read();
        }
    }
}
