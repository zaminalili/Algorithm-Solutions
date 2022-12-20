using System;
using System.Collections.Generic;

namespace DiagonalDifference
{

    public class Program
    {

        /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonal = 0;
            int rightDiagonal = 0;


            for (int j = 0; j < arr.Count; j++)
            {
                leftDiagonal += arr[j][j];
                rightDiagonal += arr[j][arr.Count - (j + 1)];
            }


            return Math.Abs(leftDiagonal - rightDiagonal);
        }


        static void Main(string[] args)
        {
            List<List<int>> matris = new List<List<int>>() { new List<int>(){1, 2, 3}, new List<int>() { 1, 2, 3 }, new List<int>() { 1, 2, 3 } };

            Console.WriteLine(matris);
        }
    }
}
