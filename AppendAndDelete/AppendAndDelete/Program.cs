static string appendAndDelete(string s, string t, int k)
{
	int sameChar = 0;
	int sLength = s.Length;
	int tLength = t.Length;
	int result;
	
    for (int i = 0; i < (sLength < tLength ? sLength : tLength); i++)
     {
        if (s[i] == t[i])
             sameChar++;
        else
             break;
    }

    result = sLength + tLength - 2 * sameChar;


    return k >= sLength + tLength || k >= result && (k - result) % 2 == 0 ? "Yes" : "No";
}

string s = "aaaaaaaaaa";
string t = "aaaaa";
int k = 7;

Console.WriteLine(appendAndDelete(s, t, k));