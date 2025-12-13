using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите номер s: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("Введите номер k (k > s): ");
        int k = int.Parse(Console.ReadLine());

        if (s > 0 && k <= word.Length && s < k)
        {
            char sLetter = word[s - 1];
            string beforeS = word.Substring(0, s - 1);
            string between = word.Substring(s, k - s - 1);
            char kLetter = word[k - 1];
            string afterK = word.Substring(k);

            string result = beforeS + between + sLetter + kLetter + afterK;

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректные значения s и k");
        }
    }
}