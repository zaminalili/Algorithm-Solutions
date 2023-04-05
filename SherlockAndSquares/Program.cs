static int squares(int a, int b)
{
    return Convert.ToInt32(Math.Floor(Math.Sqrt(b)) - Math.Ceiling(Math.Sqrt(a))+1);
}

int a = 100;
int b = 1000;

Console.WriteLine(squares(a, b));

