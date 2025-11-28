using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 5, 5, 5, 5, 8, 10, 12, 15, 18, 20 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int perviyElement = massiv[0];
        int count = 0;

        while (count < massiv.Length && massiv[count] == perviyElement)
        {
            count++;
        }

        Console.WriteLine($"Количество одинаковых элементов в начале: {count}");

        Console.WriteLine("Элементы после последнего одинакового:");
        for (int i = count; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}