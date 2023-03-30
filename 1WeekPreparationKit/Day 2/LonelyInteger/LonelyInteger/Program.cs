static int lonelyinteger(List<int> a)
{
    while (true)
    {
        int e = a[0];
        a.RemoveAt(0);

        if (!Contains(a, e))
            return e;
        else
            a.Remove(e);
    }   
}

static bool Contains(List<int> arr, int item)
{
    
    foreach (int e in arr)
        if(item == e)
            return true;

    return false;
}

List<int> a = new List<int>() { 1, 2, 3, 4, 3, 2, 1 };

Console.WriteLine(lonelyinteger(a));