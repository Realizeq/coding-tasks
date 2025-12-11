using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        bool hasFive = false;

        for (int i = 0; i < text.Length - 4; i++)
        {
            if (text[i] == text[i + 1] && text[i] == text[i + 2] &&
                text[i] == text[i + 3] && text[i] == text[i + 4])
            {
                hasFive = true;
                break;
            }
        }

        if (hasFive)
        {
            Console.WriteLine("Верно, есть пять одинаковых символов подряд");
        }
        else
        {
            Console.WriteLine("Нет пяти одинаковых символов подряд");
        }
    }
}