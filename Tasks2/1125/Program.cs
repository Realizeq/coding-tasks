using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int sum = 0;
        string currentNumber = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                currentNumber += text[i];
            }
            else if (currentNumber != "")
            {
                sum += int.Parse(currentNumber);
                currentNumber = "";
            }
        }

        if (currentNumber != "")
        {
            sum += int.Parse(currentNumber);
        }

        Console.WriteLine($"Сумма всех чисел в тексте: {sum}");
    }
}