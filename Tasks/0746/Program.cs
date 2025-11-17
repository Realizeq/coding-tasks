using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 4.5, 0, -9.2, 16.7, 0, -25.1, 36.8, -49.3, 0, 100.4 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"massiv[{i}] = {massiv[i]}");
        }

        Console.WriteLine("а) Вычитание элементов:");
        Console.Write("Введите k1: ");
        int k1 = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        double n = double.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                massiv[i] -= massiv[k1];
            }
            else if (massiv[i] < 0)
            {
                massiv[i] -= n;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("б) Изменение элементов:");
        Console.Write("Введите n: ");
        n = double.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] == 0)
            {
                massiv[i] += n;
            }
            else if (massiv[i] > 0)
            {
                massiv[i] -= a;
            }
            else
            {
                massiv[i] += b;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}