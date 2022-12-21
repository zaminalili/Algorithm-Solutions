using System;
using System.Collections.Generic;

namespace CountApplesAndOranges
{
    public class Program
    {

        /*
         * Problem:
         Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Using the information given below, determine the number of apples and oranges that land on Sam's house.

         In the diagram below:

        - The red region denotes the house, where s is the start point, and t is the endpoint. The apple tree is to the left of the house, and the orange tree is to its right.
        - Assume the trees are located on a single point, where the apple tree is at point a, and the orange tree is at point b.
        - When a fruit falls from its tree, it lands d units of distance from its tree of origin along the x-axis. *A negative value of d means the fruit fell d units to the tree's left, and a positive value of d means it falls d units to the tree's right. *
        
        Problem image: https://s3.amazonaws.com/hr-challenge-images/25220/1474218925-f2a791d52c-Appleandorange2.png

        Function Description

        Complete the countApplesAndOranges function in the editor below. It should print the number of apples and oranges that land on Sam's house, each on a separate line.

        countApplesAndOranges has the following parameter(s):

        s: integer, starting point of Sam's house location.
        t: integer, ending location of Sam's house location.
        a: integer, location of the Apple tree.
        b: integer, location of the Orange tree.
        apples: integer array, distances at which each apple falls from the tree.
        oranges: integer array, distances at which each orange falls from the tree.
         
         */



        /*
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s
     *  2. INTEGER t
     *  3. INTEGER a
     *  4. INTEGER b
     *  5. INTEGER_ARRAY apples
     *  6. INTEGER_ARRAY oranges
     */

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;

            foreach (var d in apples)
            {
                if (a + d >= s && a + d <= t)
                {
                    applesCount++;
                }
            }

            foreach (var d in oranges)
            {
                if (b + d >= s && b + d <= t)
                {
                    orangesCount++;
                }
            }

            Console.Write($"{applesCount}\n{orangesCount}");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
