using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string text = Console.ReadLine();

        int sum = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                sum += text[i] - '0';
            }
        }

        Console.WriteLine($"Сумма цифр числа: {sum}");
    }
}