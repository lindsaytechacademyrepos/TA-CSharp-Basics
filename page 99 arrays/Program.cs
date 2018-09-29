using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_99_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.

            string[] array1 = new string[] { "Lindsay's birthdate", "Stephanie's birthdate", "Jennifer's birthdate", "Karen's birthdate", "Jeremy's birthdate", };
            Console.WriteLine("Please select a number 0 through 4");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array1[input1]);

            //2.Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] array2 = { 13, 30, 10, 8, 20 };
            Console.WriteLine("Please select a number 0 through 4");
            int input2 = Convert.ToInt32(Console.ReadLine());

            //3.Add in a message that displays when the user selects an index that doesn’t exist.
            if (input2 > 4 || input2 < 0)
            {
                Console.WriteLine("Unfortunately that is not an acceptable number. Please choose a number between 0 and 4");
            }
            Console.WriteLine("The value at that index is " + array2[input2]);

            //4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            List<string> stringList = new List<string>();
            stringList.Add("here is an item");
            stringList.Add("here is item 2");
            stringList.Add("here is item 3");
            stringList.Add("here is item 4");
            stringList.Add("here is item 5");
            stringList.Add("here is item 6");

            Console.WriteLine("Please select a number 0 through 5");

            Console.WriteLine("The string at that index is \"" + stringList[Convert.ToInt32(Console.ReadLine())]+"\"");


            Console.Read();

        }
    }
}
