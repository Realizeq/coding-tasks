using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите число k: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 0 && k <= word.Length)
        {
            string pervyeK = word.Substring(0, k);
            string ostatok = word.Substring(k);
            string result = ostatok + pervyeK;
            Console.WriteLine($"Способ 1: {result}");

            string result2 = "";
            for (int i = k; i < word.Length; i++)
            {
                result2 += word[i];
            }
            for (int i = 0; i < k; i++)
            {
                result2 += word[i];
            }
            Console.WriteLine($"Способ 2: {result2}");
        }
        else
        {
            Console.WriteLine("Некорректное значение k");
        }
    }
}