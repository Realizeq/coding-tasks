using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.WriteLine("Буквосочетания 'нн':");

        for (int i = 0; i < predlozhenie.Length - 1; i++)
        {
            if ((predlozhenie[i] == 'н' && predlozhenie[i + 1] == 'н') ||
                (predlozhenie[i] == 'Н' && predlozhenie[i + 1] == 'Н') ||
                (predlozhenie[i] == 'н' && predlozhenie[i + 1] == 'Н') ||
                (predlozhenie[i] == 'Н' && predlozhenie[i + 1] == 'н'))
            {
                Console.WriteLine($"Позиция {i + 1}-{i + 2}: {predlozhenie[i]}{predlozhenie[i + 1]}");
            }
        }
    }
}