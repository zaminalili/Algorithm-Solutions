using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    public class Program
    {

        /*
        -- Problem:
        Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, return the smallest of their ids.

        Example
        arr = [1,1,2,2,3]
        There are two each of types 1 and 2, and one sighting of type 3. Pick the lower of the two types seen twice: type 1.

        Function Description

        Complete the migratoryBirds function in the editor below.

        migratoryBirds has the following parameter(s):
            int arr[n]: the types of birds sighted
        
        Returns
            int: the lowest type id of the most frequently sighted birds

         */


        /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> typesNumber = new Dictionary<int, int>() { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

            foreach (var item in arr) 
                typesNumber[item]++;

            return typesNumber.First(x => x.Value == typesNumber.Values.Max()).Key;

        }



        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 4, 4, 4, 5, 3};
            Console.WriteLine(migratoryBirds(arr));
        }
    }
}
