using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите арифметическое выражение: ");
        string expression = Console.ReadLine();

        int balance = 0;
        bool correct = true;
        int firstExtraRight = -1;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                balance++;
            }
            else if (expression[i] == ')')
            {
                balance--;

                if (balance < 0 && firstExtraRight == -1)
                {
                    firstExtraRight = i + 1;
                }
            }
        }

        correct = (balance == 0 && firstExtraRight == -1);

        Console.WriteLine($"а) Правильно расставлены скобки: {(correct ? "да" : "нет")}");

        if (!correct)
        {
            if (firstExtraRight != -1)
            {
                Console.WriteLine($"б) Лишняя правая скобка на позиции: {firstExtraRight}");
            }

            if (balance > 0)
            {
                Console.WriteLine($"б) Лишних левых скобок: {balance}");
            }
        }
        else
        {
            Console.WriteLine("б) Скобки расставлены правильно");
        }
    }
}