using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    public class Program
    {


        /*
         * You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

            Example
            candles = [4, 4, 1, 3]

        The maximum height candles are 4 units high. There are 2 of them, so return 2.

        Function Description

        Complete the function birthdayCakeCandles in the editor below.

        birthdayCakeCandles has the following parameter(s):
            - int candles[n]: the candle heights
        Returns
            - int: the number of candles that are tallest

        */


        /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

        public static int birthdayCakeCandles(List<int> candles)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>() { };

            foreach (var item in candles)
            {


                try
                {
                    keyValuePairs[item] = keyValuePairs[item] + 1;
                }
                catch (Exception)
                {

                    keyValuePairs.Add(item, 1);
                }
            }


            return keyValuePairs.Values.Max();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
