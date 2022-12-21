using System;
using System.Collections.Generic;

namespace GradingStudents
{
    public class Program
    {

        /*
         * Problem:
        HackerLand University has the following grading policy:

        Every student receives a grade in the inclusive range from 0 to 100.
        Any grade less than 40 is a failing grade.

        Sam is a professor at the university and likes to round each student's grade according to these rules:

        If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
        If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.

        Examples:
         - grade = 84 round to  85(85 - 84 is less than 3)
         - grade = 29 do not round (result is less than 40)
         - grade = 57 do not round (60 - 57 is 3 or higher)

        Given the initial value of grade for each of Sam's n students, write code to automate the rounding process.
         */


        /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */
        public static List<int> gradingStudents(List<int> grades)
        {

            List<int> finalGrades = new List<int>();

            foreach (var grade in grades)
            {
                int multiplateGrade = 5 * (grade / 5 + 1);

                if (multiplateGrade - grade < 3 && grade > 37)
                {
                    finalGrades.Add(multiplateGrade);
                }
                else
                {
                    finalGrades.Add(grade);
                }

            }

            return finalGrades;

        }


        static void Main(string[] args)
        {
            
        }
    }
}
