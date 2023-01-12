using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    public class Program
    {

        /*
         Problem: https://www.hackerrank.com/challenges/electronics-shop/problem
         */

        /*
     * Complete the getMoneySpent function below.
     */
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {

            List<int> allSpentSum = new List<int>();

            foreach (var keyboard in keyboards)
            {
                if (keyboard < b)
                {
                    foreach (var drive in drives)
                    {
                        if (drive < b && keyboard + drive <= b)
                        {
                            allSpentSum.Add(keyboard + drive);
                        }

                    }
                }
          
            }

            return allSpentSum.Count>0 ? allSpentSum.Max() : -1;
        }

        static void Main(string[] args)
        {
            //int[] keyboards = { 40, 50, 60};
            //int[] drives = { 5, 8, 12};
            //int b = 60;

            int[] keyboards = { 4 };
            int[] drives = { 5 };
            int b = 5;

            Console.WriteLine(getMoneySpent(keyboards, drives, b));
        }
    }
}
