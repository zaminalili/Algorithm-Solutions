using System;

namespace Staircase
{
    public class Program
    {

        
        /*Staircase detail
         This is a staircase of size n=4:

               #
              ##
             ###
            ####

        Its base and height are both equal to n. It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

        Write a program that prints a staircase of size n.
         
         */




        /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string space = "";
                string sharp = "";

                for (int j = 0; j < n - 1 - i; j++)
                {
                    space += " ";
                }

                for (int k = 0; k < i + 1; k++)
                {
                    sharp += "#";
                }

                Console.WriteLine(space + sharp);
            }
        }


        static void Main(string[] args)
        {
            staircase(6);
        }
    }
}
