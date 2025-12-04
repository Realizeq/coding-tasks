using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == ' ')
            {
                count++;
            }
        }

        Console.WriteLine($"Количество пробелов: {count}");
    }
}