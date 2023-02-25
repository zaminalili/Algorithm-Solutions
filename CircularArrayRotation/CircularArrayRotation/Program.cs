// Problem: https://www.hackerrank.com/challenges/circular-array-rotation/problem

static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
	List<int> rotates = new List<int>();

	foreach (int q in queries)
	{
		int i = q - k % a.Count;

        rotates.Add(a[i<0 ? ^Math.Abs(i) : i]);
    }

	return rotates;
}

//List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
//int k = 1;
//List<int> queries = new List<int>() {0, 1, 2 };

List<int> a = new List<int>() { 3, 4, 5};
int k = 5;
List<int> queries = new List<int>() { 1};

Console.WriteLine(circularArrayRotation(a, k, queries));
