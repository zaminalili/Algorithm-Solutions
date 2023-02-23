// Problem: https://www.hackerrank.com/challenges/save-the-prisoner/problem

static int saveThePrisoner(int n, int m, int s)
{
        int result = (m + s - 1) % n;

        return result == 0 ? n : result;
}


Console.WriteLine(saveThePrisoner(208526924, 756265725, 150817879));

Console.WriteLine(saveThePrisoner(962975336, 972576181, 396355184));

Console.WriteLine(saveThePrisoner(5,10,1));