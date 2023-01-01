using System;
using System.Collections.Generic;
using System.Linq;

namespace BonAppetit
{
    public class Program
    {

        /*
         -- Problem:
 Two friends Anna and Brian, are deciding how to split the bill at a dinner. Each will only pay for the items they consume. Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.
        

         Function Description

        Complete the bonAppetit function in the editor below. It should print Bon Appetit if the bill is fairly split. Otherwise, it should print the integer amount of money that Brian owes Anna.

        bonAppetit has the following parameter(s):

        bill: an array of integers representing the cost of each item ordered
        k: an integer representing the zero-based index of the item Anna doesn't eat
        b: the amount of money that Anna contributed to the bill
         */



        /*
     * Complete the 'bonAppetit' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY bill
     *  2. INTEGER k
     *  3. INTEGER b
     */

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int costPerPerson = (bill.Sum() - bill[k])/2;
            int overcharged = b - costPerPerson;

            string message = "";

            //switch (overcharged)
            //{
            //    case 0:
            //        Console.Write("Bon Appetit");
            //        break;
            //    case >0:
            //        Console.Write($"{overcharged}");
            //        break;
            //}

            switch (overcharged)
            {
                case 0:
                    message = "Bon Appetit";
                    break;
                case > 0:
                    message = overcharged.ToString();
                    break;
            }

            Console.Write(message);
        }


        static void Main(string[] args)
        {
            List<int> bill = new List<int> { 3, 10, 2, 9 };
            int k = 1;
            int b = 7;

            bonAppetit(bill, k, b);

        }
    }
}
