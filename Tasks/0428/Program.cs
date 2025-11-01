using System;
class Program
{
    static void Main()
    {
        int n = 13579;
        string s = n.ToString();
        bool vozrastaet = true;
        bool ubivaet = true;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] >= s[i + 1]) vozrastaet = false;
            if (s[i] <= s[i + 1]) ubivaet = false;
        }

        if (vozrastaet || ubivaet) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}