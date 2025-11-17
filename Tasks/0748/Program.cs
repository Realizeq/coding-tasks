using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 14, 23, 34, 45, 54, 67, 74, 89, 94, 103 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("а) Элементы, оканчивающиеся на 4, уменьшены вдвое:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 10 == 4)
            {
                massiv[i] /= 2;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("б) Четные заменены на квадраты, нечетные удвоены:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                massiv[i] = massiv[i] * massiv[i];
            }
            else
            {
                massiv[i] *= 2;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("в) Изменение элементов:");
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 == 0)
            {
                massiv[i] += a;
            }
            if (i % 2 == 0)
            {
                massiv[i] -= b;
            }
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}