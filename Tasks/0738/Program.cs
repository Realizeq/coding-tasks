using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, 7, 24, 15, 36, 9, 48, 21, 60, 33 };

        Console.WriteLine("Четные элементы:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }

        Console.WriteLine("Нечетные элементы:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 != 0)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }
    }
}