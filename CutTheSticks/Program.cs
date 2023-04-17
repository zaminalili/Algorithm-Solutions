//static List<int> cutTheSticks(List<int> arr)
//{
//	List<int> sticksCut = new List<int>();
//	List<int> nArr = new List<int>() {};

//	while (arr.Count != 0)
//	{
//		nArr = Array.Copy();

//		foreach (var item in nArr)
//		{
//			sticksCut.Add(arr.Count);

//			int minLenght = arr.Min();
//			int index = arr.IndexOf(item);

//			int newStick = item - minLenght;

//			arr.Remove(item);

//			if (newStick != 0)
//				arr[index] = newStick;

//		}
//	}



//	return sticksCut;
//}

static List<int> cutTheSticks(List<int> arr)
{
    List<int> sticksCut = new List<int>();
    List<int> sticksLength = new List<int>();

    while (arr.Count > 0)
    {
        sticksCut.Add(arr.Count);
        
        int lengthOfCut = arr.Min();

        foreach (var item in arr)
        {
            int diff = item - lengthOfCut;
            if(diff != 0)
                sticksLength.Add(diff);
        }

        arr.Clear();
        foreach (var item in sticksLength)
            arr.Add(item);
        sticksLength.Clear();
       
    }

    return sticksCut;
}


//List<int> arr = new List<int>() { 5, 4, 4, 2, 2, 8};
List<int> arr = new List<int>() { 1, 2, 3, 4, 3, 3, 2, 1 };

foreach (var item in cutTheSticks(arr))
    Console.WriteLine(item);