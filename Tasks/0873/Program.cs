using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -25, 8, -30, 12, 35, -18, 40, -5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Удалены все отрицательные элементы:");
        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= 0)
            {
                massiv[count] = massiv[i];
                count++;
            }
        }
        for (int i = count; i < massiv.Length; i++)
        {
            massiv[i] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Удалены все элементы больше n:");
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] <= n)
            {
                massiv[count] = massiv[i];
                count++;
            }
        }
        for (int i = count; i < massiv.Length; i++)
        {
            massiv[i] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Удалены элементы с n1 по n2:");
        Console.Write("Введите n1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Введите n2: ");
        int n2 = int.Parse(Console.ReadLine());
        int shift = n2 - n1 + 1;
        for (int i = n1; i < massiv.Length - shift; i++)
        {
            massiv[i] = massiv[i + shift];
        }
        for (int i = massiv.Length - shift; i < massiv.Length; i++)
        {
            massiv[i] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}