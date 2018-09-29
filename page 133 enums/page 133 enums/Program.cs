using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_133_enums
{
    class Program
    {
        enum CustomDaysOfWeek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            //get actual current day of week
            DayOfWeek currentDayOfWeek = new DayOfWeek();
            currentDayOfWeek = System.DateTime.Today.DayOfWeek;
            
            //get user input
            string userInput = Console.ReadLine();

            //parse user input to enum value
            CustomDaysOfWeek day = (CustomDaysOfWeek)Enum.Parse(typeof(CustomDaysOfWeek), userInput);


            if (day == CustomDaysOfWeek.wednesday)
            {
                Console.WriteLine("You are correct, today is " + userInput);

            }
            else
            {
                Console.WriteLine("Today is not " + userInput);
            }

            Console.Read();
        }
    }
}
