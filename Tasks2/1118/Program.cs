using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        bool isNumber = true;

        if (text.Length == 0)
        {
            isNumber = false;
        }
        else
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 && text[i] == '-')
                {
                    continue;
                }
                if (text[i] < '0' || text[i] > '9')
                {
                    isNumber = false;
                    break;
                }
            }
        }

        if (isNumber)
        {
            Console.WriteLine("Текст является правильной записью целого числа");
        }
        else
        {
            Console.WriteLine("Текст не является правильной записью целого числа");
        }
    }
}