using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите последовательность символов: ");
        string posledovatelnost = Console.ReadLine();

        if (posledovatelnost.Length > 0)
        {
            char firstChar = posledovatelnost[0];
            int count = 1;

            for (int i = 1; i < posledovatelnost.Length; i++)
            {
                if (posledovatelnost[i] == firstChar)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Количество одинаковых символов в начале: {count}");

            if (count < posledovatelnost.Length)
            {
                Console.WriteLine("Не все символы одинаковые");
            }
            else
            {
                Console.WriteLine("Все символы одинаковые");
            }
        }
        else
        {
            Console.WriteLine("Последовательность пустая");
        }
    }
}