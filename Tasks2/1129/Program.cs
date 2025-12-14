using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите выражение (например, 1+25+3): ");
        string expression = Console.ReadLine();

        int sum = 0;
        string currentNumber = "";

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] >= '0' && expression[i] <= '9')
            {
                currentNumber += expression[i];
            }
            else if (expression[i] == '+')
            {
                if (currentNumber != "")
                {
                    sum += int.Parse(currentNumber);
                    currentNumber = "";
                }
            }
        }

        if (currentNumber != "")
        {
            sum += int.Parse(currentNumber);
        }

        Console.WriteLine($"Сумма: {sum}");
    }
}