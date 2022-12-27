using System;
using System.Collections.Generic;

namespace DivisibleSumPairs
{
    public class Program
    {

        /* 
    ---- Problem:
         Given an array of integers and a positive integer k, determine the number of (i,j) pairs where i<j and ar[i] + ar[j] is divisible by k.

        Example
        ar = [1, 2, 3, 4, 5, 6]
        k = 5

        Three pairs meet the criteria: [1,4],[2,3] and [4,6].

        Function Description

        Complete the divisibleSumPairs function in the editor below.

        divisibleSumPairs has the following parameter(s):
            int n: the length of array ar
            int ar[n]: an array of integers
            int k: the integer divisor

        Returns
        - int: the number of pairs
         */



        /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int numberOfPairs = 0;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if ((ar[i]+ar[j]) % k == 0)
                    {
                        numberOfPairs++;
                    }
                }
            }

            return numberOfPairs;
        }

        static void Main(string[] args)
        {
            int k = 5;
            int n = 6;
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 5};

            Console.WriteLine(divisibleSumPairs(n, k, arr));
        }
    }
}
