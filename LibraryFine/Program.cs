static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
{
    int fine = 0;

    if(y1 > y2)
        fine = 10000;
    else if(y1 == y2)
    {
        if(m1 == m2 && d1 > d2)
            fine = 15 * (d1 - d2);
        else if(m1 > m2)
            fine = 500 * (m1 - m2);
    }

    return fine;
}

int d1, d2, m1, m2, y1, y2;

//d1 = 14; m1 = 7;  y1 = 2018;
//d2 = 5;  m2 = 7; y2 = 2018;

d1 = 28; m1 = 2; y1 = 2015;
d2 = 15; m2 = 4; y2 = 2015;

Console.WriteLine(libraryFine(d1, m1, y1, d2, m2, y2));