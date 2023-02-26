// Problem: https://www.hackerrank.com/challenges/permutation-equation/problem

static List<int> permutationEquation(List<int> p)
{
    List<int> y = new List<int>();

    for (int i = 1; i <= p.Count; i++)
        y.Add(p.IndexOf(p.IndexOf(i) + 1) + 1);

    return y;
}

List<int> p = new List<int> { 5, 2, 1, 3, 4 };

permutationEquation(p);