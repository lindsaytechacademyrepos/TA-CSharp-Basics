using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_105_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>
            {
                1, 45, 6, 23,53,7,92, 34, 5
            };
            

            try
            {
                Console.WriteLine("Please enter a whole number.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int number in integers)
                {
                    Console.WriteLine(number / userInput);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividing by zero will cause the heat death of the universe. Please select a different number");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The entry must be a whole number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("This is what's in the finally block");
            }
            

            Console.Read();
        }
    }
}
