using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 4.5, 0, -9.2, 16.7, 0, -25.1, 36.8, -49.3, 0, 100.4 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("а) Изменение элементов:");
        Console.Write("Введите a1: ");
        int a1 = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                massiv[i] += massiv[a1];
            }
            else if (massiv[i] == 0)
            {
                massiv[i] -= b;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("б) Изменение элементов:");
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                massiv[i] -= a;
            }
            else if (massiv[i] < 0)
            {
                massiv[i] -= b;
            }
            else
            {
                massiv[i] += c;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}