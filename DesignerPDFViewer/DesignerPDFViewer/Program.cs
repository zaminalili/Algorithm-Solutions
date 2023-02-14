// Problem: https://www.hackerrank.com/challenges/designer-pdf-viewer/problem


int designerPdfViewer(List<int> h, string word)
{

    //List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    List<char> alphabet = Enumerable.Range('a', 26).Select(a => (char)a).ToList();

    int maxValue = 0;

    foreach (char letter in word)
    {
        //int index = alphabet.IndexOf(letter);

        //int value = h[index];
        
        int value = h[alphabet.IndexOf(letter)];

        if (value > maxValue)
            maxValue = value;
    }

    return maxValue*word.Length;
}


List<int> h = new List<int>() { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

string word = "abc";

Console.WriteLine(designerPdfViewer(h, word));



