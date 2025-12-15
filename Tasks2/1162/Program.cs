using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int balance = 0;
        bool correct = true;
        int firstExtraRight = -1;
        int extraLeftCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '(')
            {
                balance++;
            }
            else if (text[i] == ')')
            {
                balance--;

                if (balance < 0 && firstExtraRight == -1)
                {
                    firstExtraRight = i + 1;
                }
            }
        }

        if (balance > 0)
        {
            extraLeftCount = balance;
        }

        correct = (balance == 0 && firstExtraRight == -1);

        Console.WriteLine($"а) Правильно расставлены скобки: {(correct ? "да" : "нет")}");

        if (!correct)
        {
            if (firstExtraRight != -1)
            {
                Console.WriteLine($"б) Лишняя правая скобка на позиции: {firstExtraRight}");
            }

            if (extraLeftCount > 0)
            {
                Console.WriteLine($"б) Лишних левых скобок: {extraLeftCount}");
            }
        }
        else
        {
            Console.WriteLine("б) Скобки расставлены правильно");
        }
    }
}