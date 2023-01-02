using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    public class Program
    {

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

            for (int i = 0; i < ar.Count-1; i++)
            {
                for (int j = i+1; j < ar.Count; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        pairsOfSocks++;
                        ar.Remove(ar[j]);
                        break;
                    }
                    
                }
            }

            return pairsOfSocks;
        }



        static void Main(string[] args)
        {
            List<int> ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = 9;

            Console.WriteLine(sockMerchant(n, ar));
        }
    }
}
