using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите номер k: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 0 && k < word.Length)
        {
            char lastLetter = word[word.Length - 1];
            string beforeK = word.Substring(0, k - 1);
            string afterK = word.Substring(k - 1, word.Length - k);

            string result = beforeK + lastLetter + afterK;

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректное значение k");
        }
    }
}