using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите номер s: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Введите номер k (k < s): ");
        int k = int.Parse(Console.ReadLine());

        if (s > k && k > 0 && s <= word.Length)
        {
            char sLetter = word[s - 1];
            string beforeK = word.Substring(0, k - 1);
            string between = word.Substring(k - 1, s - k);
            string afterS = word.Substring(s);

            string result = beforeK + sLetter + between + afterS;

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректные значения s и k");
        }
    }
}