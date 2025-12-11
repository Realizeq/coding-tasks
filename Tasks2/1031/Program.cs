using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '+' || text[i] == '-')
            {
                count++;
            }
        }

        Console.WriteLine($"Общее число символов + и -: {count}");
    }
}