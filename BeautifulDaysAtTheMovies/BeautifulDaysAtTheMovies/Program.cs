// Problem: https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem

static int beautifulDays(int i, int j, int k)
{
	int totalBeautifulDay = 0;

	for (int n = i; n <= j; n++)
		if(Math.Abs(n - reverseInt(n)) % k == 0)
			totalBeautifulDay++;

	return totalBeautifulDay;
}


static int reverseInt(int number)
{
	string reverseNum = "";

	foreach (char item in number.ToString())
		reverseNum = item + reverseNum;

	return Convert.ToInt32(reverseNum);

}


Console.WriteLine(beautifulDays(20, 23, 6));