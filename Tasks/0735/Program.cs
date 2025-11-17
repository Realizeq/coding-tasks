using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 5, 12, 345, 78, 9, 456, 23, 1000, 67, 890, 1, 99 };

        Console.WriteLine("а) Двузначные числа:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= 10 && massiv[i] <= 99)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }

        Console.WriteLine("б) Трехзначные числа:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= 100 && massiv[i] <= 999)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }
    }
}