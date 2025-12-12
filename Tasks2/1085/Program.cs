using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        string result = "";

        if (word.Length % 2 == 1)
        {
            int middle = word.Length / 2;
            for (int i = 0; i < word.Length; i++)
            {
                if (i != middle)
                {
                    result += word[i];
                }
            }
            Console.WriteLine($"Удалена средняя буква: {result}");
        }
        else
        {
            int middle1 = word.Length / 2 - 1;
            int middle2 = word.Length / 2;
            for (int i = 0; i < word.Length; i++)
            {
                if (i != middle1 && i != middle2)
                {
                    result += word[i];
                }
            }
            Console.WriteLine($"Удалены две средние буквы: {result}");
        }
    }
}