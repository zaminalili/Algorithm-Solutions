using System;

namespace NumberLineJump
{
    public class Program
    {
        /* Problem:
         You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
            - The first kangaroo starts at location  and moves at a rate of  meters per jump.
            - The second kangaroo starts at location  and moves at a rate of  meters per jump.
You have to figure out a way to get both kangaroos at the same location at the same time as part of the show. If it is possible, return YES, otherwise return NO.

    Example
        x1 = 2
        v1 = 1
        x2 = 1
        v2 = 2

     After one jump, they are both at x=3, (x1+v1 = 2,x2 + v2 = 1 + 2 ), so the answer is YES.

     Function Description:

        Complete the function kangaroo in the editor below.

        kangaroo has the following parameter(s):

        int x1, int v1: starting position and jump distance for kangaroo 1
        int x2, int v2: starting position and jump distance for kangaroo 2
    
        Returns:
        string: either YES or NO
        
    Problem imaged: https://s3.amazonaws.com/hr-assets/0/1516005283-e74e76ff0c-kangaroo.png
         */



        /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {

            try
            {

                //The kangaroos meet at the same location after same number of jumps, and we print YES.

                // m - same number of jumps:
                // x1 + m*v1 = x2 + m*v2, so kangaroos meet at the same location.
                // m*v1 - m*v2 = x2 - x1
                // m*(v1 - v2) = x2 - x1
                // m = (x2 - x1)/(v1 - v2)

                int m = (x2 - x1) / (v1 - v2);
                int n = (x2 - x1) % (v1 - v2);


                if (n == 0 && m > 0)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }

            }
            catch (DivideByZeroException)
            {
                return "NO";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
