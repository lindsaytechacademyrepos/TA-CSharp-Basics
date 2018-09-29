using System;
using System.Collections.Generic;
using System.Linq;

namespace page_102_iteration
{
    class program
    {
        static void Main(string[] args)
        {
            //1.create a one-dimensional array of strings.ask the user to input some text.create a loop that goes through each string in the array, adding the user’s text to the string.then create a loop that prints off each string in the array on a separate line.
            Console.WriteLine("question 1");
            string[] array1 = { "append first entry here: ", "append second entry here: ", "append third entry here: ", "append fourth entry here: ", "append fifth entry here: " };
            Console.WriteLine("please enter some text.");
            string userinput = Console.ReadLine();

            for (int n = 0; n < array1.Length; n++)
            {
                array1[n] = array1[n] + userinput;
                Console.WriteLine(array1[n]);
            }

            //2.create an infinite loop.
            //Console.WriteLine("question 2");
            //int[] array2 = { 2, 6, 3, 67, 432, 21, 677, 42344, 5 };
            //int j = 0;

            //while (j == 0)
            //{
            //    Console.WriteLine(array2[j] + " is greater than 6");
            //    Console.Read();
            //}

            //3.fix the infinite loop so it will execute.
            int[] array3 = { 2, 6, 3, 67, 432, 21, 677, 42344, 5 };
            int i = 0;

            if (i == 0)
            {
                Console.WriteLine(array3[i] + " is greater than 6");
                Console.Read();
            }

            //4. create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("question 4");
            double[] movieratings1 = { 3, 3.2, 4, 5, 2.2, 3.4, 4.8 };

            for (int k = 0; k < movieratings1.Length; k++)
            {
                if (movieratings1[k] < 4)
                {
                    Console.WriteLine("the score " + movieratings1[k] + " does not qualify for an award.");
                }
            }

            //5.create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("question 5");
            double[] movieratings2 = { 3, 3.2, 4, 5, 2.2, 3.4, 4.8 };

            for (int k = 0; k <= movieratings2.Length - 1; k++)
            {
                if (movieratings2[k] == 2.2)
                {
                    Console.WriteLine("the score " + movieratings2[k] + " is literally the worst of all possible scores.");
                }
            }

            //6. create a list of strings where each item in the list is unique. ask the user to select text to search for in the list. create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
            Console.WriteLine("question 6");
            string[] roygbiv6 = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("search for a roygbiv color");
            string input = (Console.ReadLine()).ToLower();


            for (int q = 0; q < roygbiv6.Length; q++)
            {
                if (input == roygbiv6[q])
                {
                    Console.WriteLine(roygbiv6[q] + " is found at index location " + q);
                }
            }

            //7.add code to that above loop that tells a user if they put in text that isn’t in the list.
            Console.WriteLine("question 7");
            string[] roygbiv7 = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("search for a roygbiv color");
            string input7 = Console.ReadLine();

            if (roygbiv7.Contains(input7))
            {
                for (int k = 0; k < roygbiv7.Length; k++)
                {
                    if (input == roygbiv7[k])
                    {
                        Console.WriteLine(roygbiv7[k] + " is found at index location " + k);
                        Console.Read();
                    }
                }

            }
            else
            {
                Console.Write("your entry is not in the list");
                Console.Read();
            }

            //8.add code to that above loop that stops it from executing once a match has been found.
            Console.WriteLine("question 7");
            string[] roygbiv8 = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            Console.WriteLine("search for a roygbiv color");
            string input8 = Console.ReadLine();

            if (roygbiv8.Contains(input8))
            {
                for (int k = 0; k < roygbiv8.Length; k++)
                {
                    if (input8 == roygbiv8[k])
                    {
                        Console.WriteLine(roygbiv8[k] + " is found at index location " + k);
                        break;
                    }
                }

            }
            else
            {
                Console.Write("your entry is not in the list");
                Console.Read();
            }           

            //9.create a list of strings that has at least two identical strings in the list. ask the user to select text to search for in the list.create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
            Console.WriteLine("question 9");
            string[] roygbiv9 = { "red", "orange", "yellow", "green", "blue", "indigo", "violet", "green" };
            Console.WriteLine("search for a roygbiv color");
            string input9 = Console.ReadLine();

            for (int m = 0; m < roygbiv9.Length; m++)
            {
                if (input9 == roygbiv9[m])
                {
                    Console.WriteLine("your input9 is found at index " + m);
                }
            }

            //10.add code to that above loop that tells a user if they put in text that isn’t in the list.
            Console.WriteLine("question 10");
            string[] roygbiv10 = { "red", "orange", "yellow", "green", "blue", "indigo", "violet", "green" };
            Console.WriteLine("search for a roygbiv color");
            string input10 = Console.ReadLine();

            if (roygbiv10.Contains(input10))
            {
                for (int r = 0; r < roygbiv10.Length; r++)
                {
                    if (input10 == roygbiv10[r])
                    {
                        Console.WriteLine("your input10 is found at index " + r);
                    }
                }
            }
            else
            {
            Console.WriteLine("your input10 is not found in the list");
            }
            
            //11.create a list of strings that has at least two identical strings in the list. create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list. 
            Console.WriteLine("question 11");
            List<string> roygbiv11 = new List<string>()
            {
                "red", "orange", "yellow", "green", "blue", "indigo", "violet", "green"
            };
            List<string> secondlist = new List<string>();

            foreach (string color in roygbiv11)
            {
                int colorcount = roygbiv11.Count(x => x.Contains(color));
                if (colorcount == 1)
                {
                    Console.WriteLine("{0} appears in the list 1 time", color);
                }
                else
                {
                    Console.WriteLine("{0} appears in the list {1} times", color, colorcount);
                }
            }

            foreach (string color in roygbiv11)
            {
                if (secondlist.Contains(color) == false)
                {
                    secondlist.Add(color);
                    Console.WriteLine("{0} has not yet appeared in the list", color);
                }
                else
                {
                    Console.WriteLine("{0} has already appeared in the list at least once", color);
                }
            }
            Console.Read();
        }
    }
}
