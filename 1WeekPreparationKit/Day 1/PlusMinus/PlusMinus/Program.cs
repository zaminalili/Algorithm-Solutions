static void plusMinus(List<int> arr)
{
    double positiveCount = 0;
    double negativeCount = 0;
    double zeroCount = 0;
    double arrCount = arr.Count;

    foreach (int item in arr)
    {
        if (item > 0)
            positiveCount++;
        else if (item < 0)
            negativeCount++;
        else
            zeroCount++;
    }

    Console.WriteLine($"{(positiveCount/arrCount):F6} \n{(negativeCount/arrCount):F6} \n{(zeroCount/arrCount):F6}");
}

List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
plusMinus(arr);