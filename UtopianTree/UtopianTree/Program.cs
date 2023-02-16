// Problem: https://www.hackerrank.com/challenges/utopian-tree/problem

static int utopianTree(int n)
{
	int total = 1;

	for (int i = 1; i <= n; i++)
	{
		if (i % 2 == 0)
            total++;
		else
            total = total * 2;
	}

    return total;
}

int n = 4;

Console.WriteLine(utopianTree(n));
