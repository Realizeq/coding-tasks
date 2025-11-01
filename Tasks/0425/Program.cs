using System;
class Program
{
    static void Main()
    {
        int n = 1478;
        string s = n.ToString();
        bool vozrastaet = true;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] >= s[i + 1])
            {
                vozrastaet = false;
                break;
            }
        }

        if (vozrastaet) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}