using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string s1 = Console.ReadLine();

        string s2 = "";

        for (int i = 0; i < s1.Length; i++)
        {
            if ((i + 1) % 2 == 1)
            {
                s2 += s1[i];
            }
        }

        Console.WriteLine($"Слово из нечетных букв: {s2}");
    }
}