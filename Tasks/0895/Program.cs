using System;
class Program
{
    static void Main()
    {
        int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine($"{m[i]}");
        }

        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        int[] temp = new int[k];
        for (int i = 0; i < k; i++)
        {
            temp[i] = m[i];
        }

        for (int i = 0; i < m.Length - k; i++)
        {
            m[i] = m[i + k];
        }

        for (int i = 0; i < k; i++)
        {
            m[m.Length - k + i] = temp[i];
        }

        Console.WriteLine("После переноса:");
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine($"{m[i]}");
        }
    }
}