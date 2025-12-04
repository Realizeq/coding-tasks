using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово (четное количество букв): ");
        string word = Console.ReadLine();

        if (word.Length % 2 == 0 && word.Length > 0)
        {
            string half1 = word.Substring(0, word.Length / 2);
            string half2 = word.Substring(word.Length / 2);
            string result = half2 + half1;
            Console.WriteLine($"Способ 1: {result}");

            string result2 = "";
            for (int i = word.Length / 2; i < word.Length; i++)
            {
                result2 += word[i];
            }
            for (int i = 0; i < word.Length / 2; i++)
            {
                result2 += word[i];
            }
            Console.WriteLine($"Способ 2: {result2}");
        }
        else
        {
            Console.WriteLine("Слово должно иметь четное количество букв");
        }
    }
}