using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 45, -12, 78, 0, -5, 120, 99, -30, 67, 150 };

        Console.WriteLine("а) Неотрицательные элементы:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= 0)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }

        Console.WriteLine("б) Элементы не превышающие 100:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] <= 100)
            {
                Console.WriteLine($"[{i}] = {massiv[i]}");
            }
        }
    }
}