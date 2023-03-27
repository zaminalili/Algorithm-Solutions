static string timeConversion(string s)
{
	string hour = s.Substring(0, 2);

	if (s.Contains("PM") && hour != "12")
		hour = Convert.ToString((Convert.ToInt32(hour) + 12));
	else if(s.Contains("AM") && hour == "12")
        hour = "00";

	return $"{hour}{s.Substring(2, 6)}";
}

string s = "12:45:54PM";

Console.WriteLine(timeConversion(s));