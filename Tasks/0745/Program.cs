using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 4.5, -9.2, 16.7, -25.1, 36.8, -49.3, 64.9, -81.6, 100.4 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("а) Вычитание элементов:");
        Console.Write("Введите k1: ");
        int k1 = int.Parse(Console.ReadLine());
        Console.Write("Введите k2: ");
        int k2 = int.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                massiv[i] -= massiv[k1];
            }
            else
            {
                massiv[i] -= massiv[k2];
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("б) Изменение элементов:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (i % 2 != 0)
            {
                massiv[i] += 1;
            }
            else
            {
                massiv[i] -= 1;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}