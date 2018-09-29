using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_75_insurance_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the following questions:
            //What is your age?
            //Have you ever had a DUI?
            //How many speeding tickets do you have?

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please enter \"Yes\" or \"No\"");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();

            //Use the following qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUI’s.
            //Applicants must not have more than 3 speeding tickets.

            int intAge = Convert.ToInt32(age);
            int intTickets = Convert.ToInt32(speedingTickets);

            bool result = (intAge > 15 && DUI == "No" && intTickets <= 3);
            Console.WriteLine("Qualified? " + result);
            Console.Read();

            //Print the result of the boolean expression created from the above business rules.
        }
    }
}
