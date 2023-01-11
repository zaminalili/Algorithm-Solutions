using System;

namespace CountingValleys
{
    public class Program
    {

        /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

        public static int countingValleys(int steps, string path)
        {
            int level = 0, numberOfValleys = 0;

            foreach (var item in path)
            {
                if (item == Convert.ToChar("U"))
                    level++;
           
                else if (item == Convert.ToChar("D"))
                    level--;

                if (level ==0 && item == Convert.ToChar("U"))
                    numberOfValleys++;
                
            }

            return numberOfValleys;

        }


        static void Main(string[] args)
        {

            int steps;
            string path;

            steps = 8;
            path = "UDDDUDUU";

            steps = 12;
            path = "DDUUDDUDUUUD";

            steps = 10;
            path = "DDUDDUUDUU";

            steps = 10;
            path = "UDUUUDUDDD";


            //steps = 10;
            //path = "DUDDDUUDUU";

            Console.WriteLine(countingValleys(steps, path));
        }
    }
}
