using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string s = Console.ReadLine();

        string t = "";

        for (int i = s.Length - 1; i >= 0; i--)
        {
            t += s[i];
        }

        Console.WriteLine($"Слово в обратном порядке: {t}");
    }
}