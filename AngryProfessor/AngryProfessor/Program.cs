// Problem: https://www.hackerrank.com/challenges/angry-professor/problem

static string angryProfessor(int k, List<int> a)
{
	int arrivedOnTime = 0;

    foreach (int item in a)
		if(item <= 0)
			arrivedOnTime++;

    return arrivedOnTime >= k ? "NO" : "YES";
}