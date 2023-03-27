static void miniMaxSum(List<int> arr)
{
    List<long> sums = new List<long>();

	long sum = Sum(arr);
	
	for (int i = 0; i < arr.Count; i++)
		sums.Add(sum - arr[i]);

	Console.WriteLine($"{sums.Min()} {sums.Max()}");
}


static long Sum(List<int> array)
{
	long total = 0;

	foreach (int e in array)
		total += e;

	return total;
}



List<int> arr = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };


miniMaxSum(arr);
