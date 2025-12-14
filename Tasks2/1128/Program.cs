using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите положительное вещественное число: ");
        string numberStr = Console.ReadLine();

        int integerDigits = 0;
        int fractionDigits = 0;
        bool afterPoint = false;

        for (int i = 0; i < numberStr.Length; i++)
        {
            if (numberStr[i] == ',')
            {
                afterPoint = true;
            }
            else if (numberStr[i] >= '0' && numberStr[i] <= '9')
            {
                if (afterPoint)
                {
                    fractionDigits++;
                }
                else
                {
                    integerDigits++;
                }
            }
        }

        Console.WriteLine($"а) Цифр в целой части: {integerDigits}");
        Console.WriteLine($"б) Цифр в дробной части: {fractionDigits}");
    }
}