using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово, оканчивающееся на '_': ");
        string word = Console.ReadLine();

        Console.Write("Введите номер буквы после которой вставить: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Введите букву для вставки: ");
        char letter = Console.ReadLine()[0];

        if (word.Length > 0 && k > 0 && k <= word.Length - 1)
        {
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                result += word[i];
                if (i == k - 1)
                {
                    result += letter;
                }
            }

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректные данные");
        }
    }
}