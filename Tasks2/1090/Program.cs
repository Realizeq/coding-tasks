using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string result = "";

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if ((i % 2 == 0) && (predlozhenie[i] == 'о' || predlozhenie[i] == 'О'))
            {
                continue;
            }
            result += predlozhenie[i];
        }

        Console.WriteLine($"Результат: {result}");
    }
}