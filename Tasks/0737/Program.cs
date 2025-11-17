using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -8, 32, -12, 45, -3, 0, 27, -20, 10 };

        Console.WriteLine("Неотрицательные элементы:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= 0)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }

        Console.WriteLine("Отрицательные элементы:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }
    }
}