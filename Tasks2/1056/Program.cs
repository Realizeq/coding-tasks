using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        bool found = false;
        int position = -1;

        for (int i = 0; i < predlozhenie.Length - 1; i++)
        {
            if (predlozhenie[i] == predlozhenie[i + 1])
            {
                found = true;
                position = i + 1;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine($"Первая пара одинаковых символов на позициях {position} и {position + 1}");
        }
        else
        {
            Console.WriteLine("Одинаковых соседних символов нет");
        }
    }
}