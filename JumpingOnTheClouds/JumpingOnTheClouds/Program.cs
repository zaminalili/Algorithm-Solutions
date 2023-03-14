static int jumpingOnClouds(int[] c, int k)
{
    int energy = 100;
    int n = c.Length;
    int i = 0;

    while (true)
    {
        i = (i + k) % n;
        energy--;

        if (c[i] == 1)
            energy -= 2;
        if (i == 0)
            break;


    }

    return energy;

}

//                    0, 1, 2, 3, 4, 5, 6, 7
int[] c = new int[] { 0, 0, 1, 0, 0, 1, 1, 0 };

//int[] c = new int[] { 1, 1, 1, 0, 1, 1, 0, 0, 0, 0 };



Console.WriteLine(jumpingOnClouds(c, 2));