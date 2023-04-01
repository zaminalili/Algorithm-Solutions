static int diagonalDifference(List<List<int>> arr)
{
    int n = arr.Count;
    int leftDiagonal = 0;
    int rightDiagonal = 0;

    for (int i = 0; i < n; ++i)
    {
        leftDiagonal += arr[i][i];
        rightDiagonal += arr[i][n-1 - i];
    }

    return Math.Abs(leftDiagonal-rightDiagonal); 
}

List<List<int>> arr = new List<List<int>>() { new List<int>() { 1, 2, 3 }, new List<int>() { 4, 5, 6 }, new List<int>() { 9, 8, 9 } };

Console.WriteLine(diagonalDifference(arr));