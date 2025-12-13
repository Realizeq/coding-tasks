using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите номер k: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 1 && k <= word.Length)
        {
            string result = word.Substring(1, k - 1) + word[0] + word.Substring(k);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректное значение k");
        }
    }
}