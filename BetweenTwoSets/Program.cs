using System;
using System.Collections.Generic;

namespace BetweenTwoSets
{
    /* Problem:
     There will be two arrays of integers. Determine all integers that satisfy the following two conditions:

            1.The elements of the first array are all factors of the integer being considered
            2.The integer being considered is a factor of all elements of the second array
     These numbers are referred to as being between the two arrays. Determine how many such numbers exist.


    Example


    There are two numbers between the arrays:  6 and 12.
    6%2=0, 6%6=0, 24%6=0 and 36%6=0 for the first value.
    12%2=0, 12%6=0 and 24%12=0, 36%12=0 for the second value. Return .


    Function Description:

    Complete the getTotalX function in the editor below. It should return the number of integers that are betwen the sets.

    getTotalX has the following parameter(s):

    int a[n]: an array of integers
    int b[m]: an array of integers
    
    Returns
    int: the number of integers that are between the sets

     * */



    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */



    public class Program
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int numbersBetweenTheArrays = 0;

            // The values we are looking for are between the last element of the first array and the first element of the second array:
            for (int i = a[^1]; i <= b[0]; i++)  
            {
                //bool firstValue = true;
                //bool secondValue = true;

                bool valueStatus = true;

                // Checks for long division into the elements of the first and second array for each value
                foreach (int j in a)
                {
                    if (valueStatus && i%j!=0)
                    {
                        valueStatus = false;
                        break;
                    }
                }

                foreach (int k in b)
                {
                    if (valueStatus && k%i != 0)
                    {
                        valueStatus = false;
                        break;
                    }
                }

                if (valueStatus)
                {
                    numbersBetweenTheArrays++;
                }

            }

            return numbersBetweenTheArrays;
 
        }


        // Solution 2
        public static int getTotalX2(List<int> a, List<int> b)
        {
            int numbersBetweenTheArrays = 0;

            int i = 1;

            while (a[^1] * i <= b[0])
            {
                bool valueStatus = true;
                int value = a[^1] * i;

                foreach (int j in a)
                {
                    if (valueStatus && value % j != 0)
                    {
                        valueStatus = false;
                        break;
                    }
                }

                foreach (int k in b)
                {
                    if (valueStatus && k % value != 0)
                    {
                        valueStatus = false;
                        break;
                    }
                }

                if (valueStatus)
                {
                    numbersBetweenTheArrays++;
                }

                i++;
            }   

            return numbersBetweenTheArrays;

        }


        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 2, 6};
            List<int> b = new List<int>() { 24, 36};

            Console.WriteLine(getTotalX2(a, b));
        }
    }
}
