// Problem: https://www.hackerrank.com/challenges/strange-advertising/problem


static int viralAdvertising(int n)
{
	int shared = 5;
	int liked;
	int cumulative = 0;

	for (int i = 0; i < n; i++)
	{
		liked = shared / 2;
		shared = liked * 3;
		cumulative += liked;
	}

    return cumulative;
}


Console.WriteLine(viralAdvertising(5));