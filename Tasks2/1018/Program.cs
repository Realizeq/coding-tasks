using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.Write("Введите первый символ: ");
        char simvol1 = Console.ReadLine()[0];

        Console.Write("Введите второй символ: ");
        char simvol2 = Console.ReadLine()[0];

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == simvol1 || predlozhenie[i] == simvol2)
            {
                Console.WriteLine($"Позиция {i + 1}: {predlozhenie[i]}");
            }
        }
    }
}