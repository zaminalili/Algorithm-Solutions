using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    public class Program
    {

        /*
         -- Problem:
        There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
        Example
        n = 7
        ar = [1,2,1,2,1,3,2]

        There is one pair of color 1 and one of color 2. There are three odd socks left, one of each color. The number of pairs is 2.

        Function Description

        Complete the sockMerchant function in the editor below.

        sockMerchant has the following parameter(s):

            int n: the number of socks in the pile
            int ar[n]: the colors of each sock
        
        Returns
            int: the number of pairs
         */



        /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

        public static int sockMerchant(int n, List<int> ar)
        {
            int pairsOfSocks = 0;


            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        pairsOfSocks++;
                        ar.RemoveAt(j);
                        break;
                    }

                }
            }

            return pairsOfSocks;
        }


        //public static void Test(List<int> arr)
        //{

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        Console.Write("Index: ");
        //        Console.WriteLine(i);
        //        Console.WriteLine(arr.Count);
                
        //        arr.Remove(arr[i+1]);
        //    }
        //}


        static void Main(string[] args)
        {
            List<int> ar = new List<int>() { 4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5 };
            //List<int> ar = new List<int>() { 0, 1, 2, 2, 3, 4, 5, 6, 7, 8 };
            int n = 20;

            Console.WriteLine(sockMerchant(n, ar));

            //List<int> arr = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Test(arr);
        }
    }
}
