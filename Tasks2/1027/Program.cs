using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < predlozhenie.Length - 1; i++)
        {
            if (predlozhenie[i] == predlozhenie[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Одинаковых соседних букв: {count}");
    }
}