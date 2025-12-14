using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int maxNumber = int.MinValue;
        string currentNumber = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                currentNumber += text[i];
            }
            else if (currentNumber != "")
            {
                int number = int.Parse(currentNumber);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                currentNumber = "";
            }
        }

        if (currentNumber != "")
        {
            int number = int.Parse(currentNumber);
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        if (maxNumber != int.MinValue)
        {
            Console.WriteLine($"Максимальное число в тексте: {maxNumber}");
        }
        else
        {
            Console.WriteLine("В тексте нет чисел");
        }
    }
}