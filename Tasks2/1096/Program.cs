using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово, оканчивающееся на '_': ");
        string word = Console.ReadLine();

        Console.Write("Введите букву для вставки: ");
        char letter = Console.ReadLine()[0];

        string result = "";
        bool inserted = false;

        for (int i = 0; i < word.Length; i++)
        {
            result += word[i];

            if (!inserted && (word[i] == 'и' || word[i] == 'И'))
            {
                result += letter;
                inserted = true;
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}