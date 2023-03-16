// Problem: https://www.hackerrank.com/challenges/extra-long-factorials/problem

using System.Numerics;

static void extraLongFactorials(int n)
{
	BigInteger result = new BigInteger(n);

	for (int i = n-1; i > 0; i--)
		result *= new BigInteger(i);

	Console.WriteLine(result);
}

extraLongFactorials(100);