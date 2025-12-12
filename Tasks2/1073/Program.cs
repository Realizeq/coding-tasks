using System;
class Program
{
    static void Main()
    {
        string s = "очепатка";

        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (i == 1 && s[i] == 'ч')
            {
                result += 'п';
            }
            else if (i == 2 && s[i] == 'е')
            {
                result += 'е';
            }
            else if (i == 3 && s[i] == 'п')
            {
                result += 'ч';
            }
            else
            {
                result += s[i];
            }
        }

        Console.WriteLine($"Исправленная строка: {result}");
    }
}