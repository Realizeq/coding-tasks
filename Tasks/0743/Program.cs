using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 4.0, -9.0, 16.0, -25.0, 36.0, -49.0, 64.0, -81.0, 100.0 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("а) Замена отрицательных на абсолютные величины:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                massiv[i] = Math.Abs(massiv[i]);
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("б) Замена элементов с нечетными номерами на корень:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (i % 2 != 0)
            {
                massiv[i] = Math.Sqrt(massiv[i]);
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}