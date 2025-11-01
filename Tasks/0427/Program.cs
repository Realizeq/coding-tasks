using System;
class Program
{
    static void Main()
    {
        int n = 1669;
        string s = n.ToString();
        bool neubivaet = true;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] > s[i + 1])
            {
                neubivaet = false;
                break;
            }
        }

        if (neubivaet) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}