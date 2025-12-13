using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        string numberStr = "";
        bool inNumber = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                numberStr += text[i];
                inNumber = true;
            }
            else if (inNumber)
            {
                break;
            }
        }

        if (numberStr != "")
        {
            int number = int.Parse(numberStr);
            Console.WriteLine($"Число из первых идущих подряд цифр: {number}");
        }
        else
        {
            Console.WriteLine("В тексте нет цифр");
        }
    }
}