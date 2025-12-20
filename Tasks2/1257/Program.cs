using System;
class Program
{
    static bool SlovoPalindrom(string slovo)
    {
        int d = slovo.Length;
        for (int i = 0; i < d / 2; i++)
        {
            if (slovo[i] != slovo[d - 1 - i])
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string s1 = Console.ReadLine();
        Console.Write("Введите второе слово: ");
        string s2 = Console.ReadLine();
        Console.Write("Введите третье слово: ");
        string s3 = Console.ReadLine();

        bool p1 = SlovoPalindrom(s1);
        bool p2 = SlovoPalindrom(s2);
        bool p3 = SlovoPalindrom(s3);

        if (p1 || p2 || p3)
        {
            Console.WriteLine("Среди слов есть палиндром(ы):");
            if (p1) Console.WriteLine(s1);
            if (p2) Console.WriteLine(s2);
            if (p3) Console.WriteLine(s3);
        }
        else
        {
            Console.WriteLine("Среди слов нет палиндромов");
        }
    }
}