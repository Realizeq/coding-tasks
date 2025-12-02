using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите номер m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите номер n: ");
        int n = int.Parse(Console.ReadLine());

        if (m > 0 && n <= word.Length && m <= n)
        {
            string result = word.Substring(m - 1, n - m + 1);
            Console.WriteLine($"Часть слова с {m}-й по {n}-ю букву: {result}");
        }
        else
        {
            Console.WriteLine("Некорректные номера символов");
        }
    }
}