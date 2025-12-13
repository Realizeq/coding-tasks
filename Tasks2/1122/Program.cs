using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите выражение (например, 1±2±3): ");
        string text = Console.ReadLine();

        int sum = 0;
        string currentNumber = "";
        bool isPositive = true;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                currentNumber += text[i];
            }
            else if (text[i] == '+' || text[i] == '±')
            {
                if (currentNumber != "")
                {
                    int number = int.Parse(currentNumber);
                    sum += isPositive ? number : -number;
                    currentNumber = "";
                }
                isPositive = (text[i] == '+');
            }
            else if (text[i] == '-')
            {
                if (currentNumber != "")
                {
                    int number = int.Parse(currentNumber);
                    sum += isPositive ? number : -number;
                    currentNumber = "";
                }
                isPositive = false;
            }
        }

        if (currentNumber != "")
        {
            int number = int.Parse(currentNumber);
            sum += isPositive ? number : -number;
        }

        Console.WriteLine($"Результат: {sum}");
    }
}