using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_155_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = System.DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Please enter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour + userInput, currentTime.Minute, currentTime.Second);
            if (userInput == 1)
            {
                Console.WriteLine("The time in 1 hour will be " + futureTime);
            }
            else
            {
                Console.WriteLine("The time in {0} hours will be " + futureTime, userInput);
            }
            //I'm aware that this is not a perfect solution because it won't account for what happens if adding the hours rolls over past midnight, but I am le tired and this works for now
            Console.Read();
        }
    }
}
