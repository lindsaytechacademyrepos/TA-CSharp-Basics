using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_94_while_and_do_while
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Making a savings account with a savings goal. 
            int balance = 0;
            int savingsGoal = 500;

            do
            {
                Console.WriteLine("Your current balance is ${0}. Your goal is ${1}.", balance, savingsGoal);
                Console.WriteLine("How much would you like to contribute to savings?");
                int savingsContribution = Convert.ToInt32(Console.ReadLine());
                balance += savingsContribution;
            }

            while (balance < savingsGoal) ;


            Console.WriteLine("Congratulations, you've reached your target balance!");

            Console.Read();
        }
    }
}
