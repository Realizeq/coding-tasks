using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        for (int i = 2; i < predlozhenie.Length; i += 3)
        {
            Console.WriteLine($"Позиция {i + 1}: {predlozhenie[i]}");
        }
    }
}