using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int count = 0;
        bool foundComma = false;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == ',')
            {
                foundComma = true;
                break;
            }

            if (predlozhenie[i] == 'н' || predlozhenie[i] == 'Н')
            {
                count++;
            }
        }

        if (foundComma)
        {
            Console.WriteLine($"Количество букв 'н' до первой запятой: {count}");
        }
        else
        {
            Console.WriteLine($"Запятых нет, количество букв 'н' во всем предложении: {count}");
        }
    }
}