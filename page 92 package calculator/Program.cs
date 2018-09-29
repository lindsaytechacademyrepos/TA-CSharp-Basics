using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_92_package_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your job is to create a console-based application for getting a shipping quote for a package.
            //REQUIREMENTS
            //The first line of the program must be: “Welcome to Package Express.Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            //The user must then be prompted for the package weight.
            Console.WriteLine("Please enter package weight: ");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The user must then be prompted for the package width.
            Console.WriteLine("Please enter package width: ");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            //Then the package height.
            Console.WriteLine("Please enter package height: ");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            //Then the package length.
            Console.WriteLine("Please enter package length: ");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            int totalDims = pkgHeight + pkgLength + pkgWidth;
            if (totalDims > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            //The total dimensions are then multiplied by the weight and then divided by 100.
            //The result of that calculation is the quote.
            int quote = totalDims * pkgWidth / 100;

            //Display the quote to the user as a dollar amount.
            Console.WriteLine("Quote: $" + quote);
            Console.Read();
        }
    }
}
