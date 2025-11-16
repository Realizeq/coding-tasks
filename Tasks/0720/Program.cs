using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Массив в обратном порядке:");
        for (int i = massiv.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}