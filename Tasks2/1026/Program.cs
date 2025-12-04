using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int plusCount = 0;
        int starCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '+')
            {
                plusCount++;
            }
            else if (text[i] == '*')
            {
                starCount++;
            }
        }

        Console.WriteLine($"Символ '+' встречается {plusCount} раз");
        Console.WriteLine($"Символ '*' встречается {starCount} раз");
    }
}