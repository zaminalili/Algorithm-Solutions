using System;

namespace DrawingBook
{
    public class Program
    {

        /*
         -- Problem:
        A teacher asks the class to open their books to a page number. A student can either start turning pages from the front of the book or from the back of the book. They always turn pages one at a time. When they open the book, page  is always on the right side: https://s3.amazonaws.com/hr-challenge-images/0/1481920803-d2b54f38f0-book.png

        https://s3.amazonaws.com/hr-challenge-images/22564/1467398281-32b69f6fa9-UntitledDiagram4.png

         */


        /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

        public static int pageCount(int n, int p)
        {

            int pagesToTurn = 0;
            int reversePagesToTurn = 0;

            //if (p%2==0)
            //{
            //    pagesToTurn = p / 2;
            //    reversePagesToTurn = n-1-pagesToTurn;

            //}
            //else if(p%2!=0)
            //{
            //    pagesToTurn=p-1/2;
            //    reversePagesToTurn = n-1-pagesToTurn;
            //}
            //else
            //{

            //}


            if (p % 2 != 0)
                p--;

            pagesToTurn = p / 2;
            //reversePagesToTurn = n/2+1 -1-pagesToTurn;
            reversePagesToTurn = n/2-pagesToTurn;

            return pagesToTurn<reversePagesToTurn ? pagesToTurn : reversePagesToTurn;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(pageCount(5, 4));
        }
    }
}
