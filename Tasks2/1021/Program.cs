using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.WriteLine("Символы на позициях 1,2,5,6,9,10,...:");

        int i = 0;
        while (i < predlozhenie.Length)
        {
            if (i < predlozhenie.Length) Console.WriteLine($"Позиция {i + 1}: {predlozhenie[i]}");
            if (i + 1 < predlozhenie.Length) Console.WriteLine($"Позиция {i + 2}: {predlozhenie[i + 1]}");
            i += 4;
            if (i < predlozhenie.Length) Console.WriteLine($"Позиция {i + 1}: {predlozhenie[i]}");
            if (i + 1 < predlozhenie.Length) Console.WriteLine($"Позиция {i + 2}: {predlozhenie[i + 1]}");
            i += 4;
        }
    }
}