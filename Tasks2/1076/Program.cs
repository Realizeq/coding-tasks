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

        if (m > 0 && n > 0 && m <= word.Length && n <= word.Length && m != n)
        {
            char[] chars = word.ToCharArray();

            char temp = chars[m - 1];
            chars[m - 1] = chars[n - 1];
            chars[n - 1] = temp;

            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректные номера букв");
        }
    }
}