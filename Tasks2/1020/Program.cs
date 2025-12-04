using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.WriteLine("Буквы 'и' на четных местах:");

        for (int i = 1; i < predlozhenie.Length; i += 2)
        {
            if (predlozhenie[i] == 'и' || predlozhenie[i] == 'И')
            {
                Console.WriteLine($"Позиция {i + 1}: {predlozhenie[i]}");
            }
        }
    }
}