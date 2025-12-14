using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int maxSpaces = 0;
        int currentSpaces = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == ' ')
            {
                currentSpaces++;
                if (currentSpaces > maxSpaces)
                {
                    maxSpaces = currentSpaces;
                }
            }
            else
            {
                currentSpaces = 0;
            }
        }

        Console.WriteLine($"Наибольшее количество идущих подряд пробелов: {maxSpaces}");
    }
}