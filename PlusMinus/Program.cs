using System;
using System.Collections.Generic;
using System.Numerics;

namespace PlusMinus
{
    internal class Program
    {

        //Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.Print the decimal value of each fraction on a new line with 6 places after the decimal.

        /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */



        public static void plusMinus(List<int> arr)
        {
            decimal numberOfPositive = 0m;
            decimal numberOfNegatives = 0m;
            decimal numberOfZeros = 0m;

            decimal arrCount = arr.Count;


            foreach (var item in arr)
            {
                switch (item)
                {
                    case > 0:
                        numberOfPositive++;
                        break;
                    case < 0:
                        numberOfNegatives++;
                        break;
                    case 0:
                        numberOfZeros++;
                        break;
                }
            }

            Console.WriteLine(String.Format("{0:0.000000}", numberOfPositive / arrCount));
            Console.WriteLine(String.Format("{0:0.000000}", numberOfNegatives / arrCount));
            Console.WriteLine(String.Format("{0:0.000000}", numberOfZeros / arrCount));
        }


        static void Main(string[] args)
        {
            plusMinus(new List<int>() { 1, 1, 0, -1, -1});
        }
    }
}
